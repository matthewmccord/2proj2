using System;
using Microsoft.EntityFrameworkCore;
namespace _2proj2.Models
{
    public class TimeFormContext : DbContext
    {
        public TimeFormContext(DbContextOptions<TimeFormContext> options) : base(options)
        {
        }

        public DbSet<User> responses { get; set; }

        public DbSet<Time> slots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
                new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 2,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 3,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 4,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 5,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 6,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                }, new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                }, new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                }, new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
                new Time
                {
                    TimeID = 1,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 8, 59, 59),
                    Available = true
                },
            ); 

            mb.Entity<User>().HasData(

                new User
                {
                    GroupId =2,
                    Name = "Austin Berg",
                    GroupSize = 25,
                    Email = "aberg21@gmail.com",
                    PhoneNumber = "123-456-7890",
                    TimeId = 1


                },
                new User
                {
                    GroupId = 2,
                    Name = "matt mccord",
                    GroupSize = 6,
                    Email = "test@test.com",
                    PhoneNumber = "123-456-7234",
                    TimeId = 4
                }      
            );
        }
    }
}

