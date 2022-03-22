using System;
using System.Collections.Generic;
using System.Linq;

namespace _2proj2.Models
{
    public class EFUserRepository : IUserRepository
    {
        private readonly TimeFormContext _context;

        public EFUserRepository(TimeFormContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.GroupId == id);
        }

        public List<User> GetScheduledUsers()
        {
            return _context.Users.Where(u => !u.IsAvailable).ToList();
        }

        public List<User> GetUsersByDate(DateTime date)
        {
            // date always comes through as midnight so nothing can satisfy condition because you need EOD as the upper bound
            DateTime EOD = date.AddDays(1).AddSeconds(-1);
            return _context.Users.Where(u => u.Start >= date && u.End <= EOD).ToList();
        }

        public User UpdateUser(User u)
        {
            _context.SaveChanges();
            return u;
        }
    }
}
