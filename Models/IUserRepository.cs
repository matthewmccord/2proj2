using System;
using System.Collections.Generic;

namespace _2proj2.Models
{
    public interface IUserRepository
    {
        public List<User> GetScheduledUsers();
        public List<User> GetUsersByDate(DateTime date);
        public User GetUserById(int id);
        public User UpdateUser(User u);
    }
}
