using System;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
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
                    Start = new DateTime(2022, 4, 1, 9, 0, 0),
                    End = new DateTime(2022, 4, 1, 9, 59, 59),
                    Available = true
                },
                 new Time
                 {
                     TimeID = 3,
                     Start = new DateTime(2022, 4, 1, 10, 0, 0),
                     End = new DateTime(2022, 4, 1, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 4,
                     Start = new DateTime(2022, 4, 1, 11, 0, 0),
                     End = new DateTime(2022, 4, 1, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 5,
                     Start = new DateTime(2022, 4, 1, 12, 0, 0),
                     End = new DateTime(2022, 4, 1, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 6,
                     Start = new DateTime(2022, 4, 1, 13, 0, 0),
                     End = new DateTime(2022, 4, 1, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 7,
                     Start = new DateTime(2022, 4, 1, 14, 0, 0),
                     End = new DateTime(2022, 4, 1, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 8,
                     Start = new DateTime(2022, 4, 1, 15, 0, 0),
                     End = new DateTime(2022, 4, 1, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 9,
                     Start = new DateTime(2022, 4, 1, 16, 0, 0),
                     End = new DateTime(2022, 4, 1, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 10,
                     Start = new DateTime(2022, 4, 1, 17, 0, 0),
                     End = new DateTime(2022, 4, 1, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 11,
                     Start = new DateTime(2022, 4, 1, 18, 0, 0),
                     End = new DateTime(2022, 4, 1, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 12,
                     Start = new DateTime(2022, 4, 1, 19, 0, 0),
                     End = new DateTime(2022, 4, 1, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 13,
                     Start = new DateTime(2022, 4, 1, 20, 0, 0),
                     End = new DateTime(2022, 4, 1, 20, 59, 59),
                     Available = true
                 },
                  new Time
                  {
                      TimeID = 14,
                      Start = new DateTime(2022, 4, 2, 8, 0, 0),
                      End = new DateTime(2022, 4, 2, 8, 59, 59),
                      Available = true
                  },
                 new Time
                 {
                     TimeID = 15,
                     Start = new DateTime(2022, 4, 2, 9, 0, 0),
                     End = new DateTime(2022, 4, 2, 9, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 16,
                     Start = new DateTime(2022, 4, 2, 10, 0, 0),
                     End = new DateTime(2022, 4, 2, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 17,
                     Start = new DateTime(2022, 4, 2, 11, 0, 0),
                     End = new DateTime(2022, 4, 2, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 18,
                     Start = new DateTime(2022, 4, 2, 12, 0, 0),
                     End = new DateTime(2022, 4, 2, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 19,
                     Start = new DateTime(2022, 4, 2, 13, 0, 0),
                     End = new DateTime(2022, 4, 2, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 20,
                     Start = new DateTime(2022, 4, 2, 14, 0, 0),
                     End = new DateTime(2022, 4, 2, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 21,
                     Start = new DateTime(2022, 4, 2, 15, 0, 0),
                     End = new DateTime(2022, 4, 2, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 22,
                     Start = new DateTime(2022, 4, 2, 16, 0, 0),
                     End = new DateTime(2022, 4, 2, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 23,
                     Start = new DateTime(2022, 4, 2, 17, 0, 0),
                     End = new DateTime(2022, 4, 2, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 24,
                     Start = new DateTime(2022, 4, 2, 18, 0, 0),
                     End = new DateTime(2022, 4, 2, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 25,
                     Start = new DateTime(2022, 4, 2, 19, 0, 0),
                     End = new DateTime(2022, 4, 2, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 26,
                     Start = new DateTime(2022, 4, 2, 20, 0, 0),
                     End = new DateTime(2022, 4, 2, 20, 59, 59),
                     Available = true
                 },
                  new Time
                  {
                      TimeID = 27,
                      Start = new DateTime(2022, 4, 3, 8, 0, 0),
                      End = new DateTime(2022, 4, 3, 8, 59, 59),
                      Available = true
                  },
                 new Time
                 {
                     TimeID = 28,
                     Start = new DateTime(2022, 4, 3, 9, 0, 0),
                     End = new DateTime(2022, 4, 3, 9, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 29,
                     Start = new DateTime(2022, 4, 3, 10, 0, 0),
                     End = new DateTime(2022, 4, 3, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 30,
                     Start = new DateTime(2022, 4, 3, 11, 0, 0),
                     End = new DateTime(2022, 4, 3, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 31,
                     Start = new DateTime(2022, 4, 3, 12, 0, 0),
                     End = new DateTime(2022, 4, 3, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 32,
                     Start = new DateTime(2022, 4, 3, 13, 0, 0),
                     End = new DateTime(2022, 4, 3, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 33,
                     Start = new DateTime(2022, 4, 3, 14, 0, 0),
                     End = new DateTime(2022, 4, 3, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 34,
                     Start = new DateTime(2022, 4, 3, 15, 0, 0),
                     End = new DateTime(2022, 4, 3, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 35,
                     Start = new DateTime(2022, 4, 3, 16, 0, 0),
                     End = new DateTime(2022, 4, 3, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 36,
                     Start = new DateTime(2022, 4, 3, 17, 0, 0),
                     End = new DateTime(2022, 4, 3, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 37,
                     Start = new DateTime(2022, 4, 3, 18, 0, 0),
                     End = new DateTime(2022, 4, 3, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 38,
                     Start = new DateTime(2022, 4, 3, 19, 0, 0),
                     End = new DateTime(2022, 4, 3, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 39,
                     Start = new DateTime(2022, 4, 3, 20, 0, 0),
                     End = new DateTime(2022, 4, 3, 20, 59, 59),
                     Available = true
                 },
                  new Time
                  {
                      TimeID = 40,
                      Start = new DateTime(2022, 4, 4, 8, 0, 0),
                      End = new DateTime(2022, 4, 4, 8, 59, 59),
                      Available = true
                  },
                 new Time
                 {
                     TimeID = 41,
                     Start = new DateTime(2022, 4, 4, 9, 0, 0),
                     End = new DateTime(2022, 4, 4, 9, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 42,
                     Start = new DateTime(2022, 4, 4, 10, 0, 0),
                     End = new DateTime(2022, 4, 4, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 43,
                     Start = new DateTime(2022, 4, 4, 11, 0, 0),
                     End = new DateTime(2022, 4, 4, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 44,
                     Start = new DateTime(2022, 4, 4, 12, 0, 0),
                     End = new DateTime(2022, 4, 4, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 45,
                     Start = new DateTime(2022, 4, 4, 13, 0, 0),
                     End = new DateTime(2022, 4, 4, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 46,
                     Start = new DateTime(2022, 4, 4, 14, 0, 0),
                     End = new DateTime(2022, 4, 4, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 47,
                     Start = new DateTime(2022, 4, 4, 15, 0, 0),
                     End = new DateTime(2022, 4, 4, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 48,
                     Start = new DateTime(2022, 4, 4, 16, 0, 0),
                     End = new DateTime(2022, 4, 4, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 49,
                     Start = new DateTime(2022, 4, 4, 17, 0, 0),
                     End = new DateTime(2022, 4, 4, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 50,
                     Start = new DateTime(2022, 4, 4, 18, 0, 0),
                     End = new DateTime(2022, 4, 4, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 51,
                     Start = new DateTime(2022, 4, 4, 19, 0, 0),
                     End = new DateTime(2022, 4, 4, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 52,
                     Start = new DateTime(2022, 4, 4, 20, 0, 0),
                     End = new DateTime(2022, 4, 4, 20, 59, 59),
                     Available = true
                 },
                  new Time
                  {
                      TimeID = 53,
                      Start = new DateTime(2022, 4, 5, 8, 0, 0),
                      End = new DateTime(2022, 4, 5, 8, 59, 59),
                      Available = true
                  },
                 new Time
                 {
                     TimeID = 54,
                     Start = new DateTime(2022, 4, 5, 9, 0, 0),
                     End = new DateTime(2022, 4, 5, 9, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 55,
                     Start = new DateTime(2022, 4, 5, 10, 0, 0),
                     End = new DateTime(2022, 4, 5, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 56,
                     Start = new DateTime(2022, 4, 5, 11, 0, 0),
                     End = new DateTime(2022, 4, 5, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 57,
                     Start = new DateTime(2022, 4, 5, 12, 0, 0),
                     End = new DateTime(2022, 4, 5, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 58,
                     Start = new DateTime(2022, 4, 5, 13, 0, 0),
                     End = new DateTime(2022, 4, 5, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 59,
                     Start = new DateTime(2022, 4, 5, 14, 0, 0),
                     End = new DateTime(2022, 4, 5, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 60,
                     Start = new DateTime(2022, 4, 5, 15, 0, 0),
                     End = new DateTime(2022, 4, 5, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 61,
                     Start = new DateTime(2022, 4, 5, 16, 0, 0),
                     End = new DateTime(2022, 4, 5, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 62,
                     Start = new DateTime(2022, 4, 5, 17, 0, 0),
                     End = new DateTime(2022, 4, 5, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 63,
                     Start = new DateTime(2022, 4, 5, 18, 0, 0),
                     End = new DateTime(2022, 4, 5, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 64,
                     Start = new DateTime(2022, 4, 5, 19, 0, 0),
                     End = new DateTime(2022, 4, 5, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 65,
                     Start = new DateTime(2022, 4, 5, 20, 0, 0),
                     End = new DateTime(2022, 4, 5, 20, 59, 59),
                     Available = true
                 },
                  new Time
                  {
                      TimeID = 66,
                      Start = new DateTime(2022, 4, 6, 8, 0, 0),
                      End = new DateTime(2022, 4, 6, 8, 59, 59),
                      Available = true
                  },
                 new Time
                 {
                     TimeID = 67,
                     Start = new DateTime(2022, 4, 6, 9, 0, 0),
                     End = new DateTime(2022, 4, 6, 9, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 68,
                     Start = new DateTime(2022, 4, 6, 10, 0, 0),
                     End = new DateTime(2022, 4, 6, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 69,
                     Start = new DateTime(2022, 4, 6, 11, 0, 0),
                     End = new DateTime(2022, 4, 6, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 70,
                     Start = new DateTime(2022, 4, 6, 12, 0, 0),
                     End = new DateTime(2022, 4, 6, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 71,
                     Start = new DateTime(2022, 4, 6, 13, 0, 0),
                     End = new DateTime(2022, 4, 6, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 72,
                     Start = new DateTime(2022, 4, 6, 14, 0, 0),
                     End = new DateTime(2022, 4, 6, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 73,
                     Start = new DateTime(2022, 4, 6, 15, 0, 0),
                     End = new DateTime(2022, 4, 6, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 74,
                     Start = new DateTime(2022, 4, 6, 16, 0, 0),
                     End = new DateTime(2022, 4, 6, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 75,
                     Start = new DateTime(2022, 4, 6, 17, 0, 0),
                     End = new DateTime(2022, 4, 6, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 76,
                     Start = new DateTime(2022, 4, 6, 18, 0, 0),
                     End = new DateTime(2022, 4, 6, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 77,
                     Start = new DateTime(2022, 4, 6, 19, 0, 0),
                     End = new DateTime(2022, 4, 6, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 78,
                     Start = new DateTime(2022, 4, 6, 20, 0, 0),
                     End = new DateTime(2022, 4, 6, 20, 59, 59),
                     Available = true
                 },
                  new Time
                  {
                      TimeID = 79,
                      Start = new DateTime(2022, 4, 7, 8, 0, 0),
                      End = new DateTime(2022, 4, 7, 8, 59, 59),
                      Available = true
                  },
                 new Time
                 {
                     TimeID = 80,
                     Start = new DateTime(2022, 4, 7, 9, 0, 0),
                     End = new DateTime(2022, 4, 7, 9, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 81,
                     Start = new DateTime(2022, 4, 7, 10, 0, 0),
                     End = new DateTime(2022, 4, 7, 10, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 82,
                     Start = new DateTime(2022, 4, 7, 11, 0, 0),
                     End = new DateTime(2022, 4, 7, 11, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 83,
                     Start = new DateTime(2022, 4, 7, 12, 0, 0),
                     End = new DateTime(2022, 4, 7, 12, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 84,
                     Start = new DateTime(2022, 4, 7, 13, 0, 0),
                     End = new DateTime(2022, 4, 7, 13, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 85,
                     Start = new DateTime(2022, 4, 7, 14, 0, 0),
                     End = new DateTime(2022, 4, 7, 14, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 86,
                     Start = new DateTime(2022, 4, 7, 15, 0, 0),
                     End = new DateTime(2022, 4, 7, 15, 59, 59),
                     Available = true
                 }, new Time
                 {
                     TimeID = 87,
                     Start = new DateTime(2022, 4, 7, 16, 0, 0),
                     End = new DateTime(2022, 4, 7, 16, 59, 59),
                     Available = true
                 }, new Time

                 {
                     TimeID = 88,
                     Start = new DateTime(2022, 4, 7, 17, 0, 0),
                     End = new DateTime(2022, 4, 7, 17, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 89,
                     Start = new DateTime(2022, 4, 7, 18, 0, 0),
                     End = new DateTime(2022, 4, 7, 18, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 90,
                     Start = new DateTime(2022, 4, 7, 19, 0, 0),
                     End = new DateTime(2022, 4, 7, 19, 59, 59),
                     Available = true
                 },
                 new Time
                 {
                     TimeID = 91,
                     Start = new DateTime(2022, 4, 7, 20, 0, 0),
                     End = new DateTime(2022, 4, 7, 20, 59, 59),
                     Available = true
                 }
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
                    GroupId = 3,
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

