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

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<User>().HasData(
               new User
               {
                   GroupId = 1,
                   Start = new DateTime(2022, 4, 1, 8, 0, 0),
                   End = new DateTime(2022, 4, 1, 8, 59, 59)
               },
               new User
               {
                   GroupId = 2,
                   Start = new DateTime(2022, 4, 1, 9, 0, 0),
                   End = new DateTime(2022, 4, 1, 9, 59, 59)
               },
                new User
                {
                    GroupId = 3,
                    Start = new DateTime(2022, 4, 1, 10, 0, 0),
                    End = new DateTime(2022, 4, 1, 10, 59, 59),
                },
                new User
                {
                    GroupId = 4,
                    Start = new DateTime(2022, 4, 1, 11, 0, 0),
                    End = new DateTime(2022, 4, 1, 11, 59, 59),
                },
                new User
                {
                    GroupId = 5,
                    Start = new DateTime(2022, 4, 1, 12, 0, 0),
                    End = new DateTime(2022, 4, 1, 12, 59, 59),
                },
                new User
                {
                    GroupId = 6,
                    Start = new DateTime(2022, 4, 1, 13, 0, 0),
                    End = new DateTime(2022, 4, 1, 13, 59, 59),
                },
                new User
                {
                    GroupId = 7,
                    Start = new DateTime(2022, 4, 1, 14, 0, 0),
                    End = new DateTime(2022, 4, 1, 14, 59, 59),
                },
                new User
                {
                    GroupId = 8,
                    Start = new DateTime(2022, 4, 1, 15, 0, 0),
                    End = new DateTime(2022, 4, 1, 15, 59, 59),
                }, new User
                {
                    GroupId = 9,
                    Start = new DateTime(2022, 4, 1, 16, 0, 0),
                    End = new DateTime(2022, 4, 1, 16, 59, 59),
                }, new User

                {
                    GroupId = 10,
                    Start = new DateTime(2022, 4, 1, 17, 0, 0),
                    End = new DateTime(2022, 4, 1, 17, 59, 59),
                },
                new User
                {
                    GroupId = 11,
                    Start = new DateTime(2022, 4, 1, 18, 0, 0),
                    End = new DateTime(2022, 4, 1, 18, 59, 59),
                },
                new User
                {
                    GroupId = 12,
                    Start = new DateTime(2022, 4, 1, 19, 0, 0),
                    End = new DateTime(2022, 4, 1, 19, 59, 59),
                },
                new User
                {
                    GroupId = 13,
                    Start = new DateTime(2022, 4, 1, 20, 0, 0),
                    End = new DateTime(2022, 4, 1, 20, 59, 59),
                },
                 new User
                 {
                     GroupId = 14,
                     Start = new DateTime(2022, 4, 2, 8, 0, 0),
                     End = new DateTime(2022, 4, 2, 8, 59, 59),
                 },
                new User
                {
                    GroupId = 15,
                    Start = new DateTime(2022, 4, 2, 9, 0, 0),
                    End = new DateTime(2022, 4, 2, 9, 59, 59),
                },
                new User
                {
                    GroupId = 16,
                    Start = new DateTime(2022, 4, 2, 10, 0, 0),
                    End = new DateTime(2022, 4, 2, 10, 59, 59),
                },
                new User
                {
                    GroupId = 17,
                    Start = new DateTime(2022, 4, 2, 11, 0, 0),
                    End = new DateTime(2022, 4, 2, 11, 59, 59),
                },
                new User
                {
                    GroupId = 18,
                    Start = new DateTime(2022, 4, 2, 12, 0, 0),
                    End = new DateTime(2022, 4, 2, 12, 59, 59),
                },
                new User
                {
                    GroupId = 19,
                    Start = new DateTime(2022, 4, 2, 13, 0, 0),
                    End = new DateTime(2022, 4, 2, 13, 59, 59),
                },
                new User
                {
                    GroupId = 20,
                    Start = new DateTime(2022, 4, 2, 14, 0, 0),
                    End = new DateTime(2022, 4, 2, 14, 59, 59),
                },
                new User
                {
                    GroupId = 21,
                    Start = new DateTime(2022, 4, 2, 15, 0, 0),
                    End = new DateTime(2022, 4, 2, 15, 59, 59),
                }, new User
                {
                    GroupId = 22,
                    Start = new DateTime(2022, 4, 2, 16, 0, 0),
                    End = new DateTime(2022, 4, 2, 16, 59, 59),
                }, new User

                {
                    GroupId = 23,
                    Start = new DateTime(2022, 4, 2, 17, 0, 0),
                    End = new DateTime(2022, 4, 2, 17, 59, 59),
                },
                new User
                {
                    GroupId = 24,
                    Start = new DateTime(2022, 4, 2, 18, 0, 0),
                    End = new DateTime(2022, 4, 2, 18, 59, 59),
                },
                new User
                {
                    GroupId = 25,
                    Start = new DateTime(2022, 4, 2, 19, 0, 0),
                    End = new DateTime(2022, 4, 2, 19, 59, 59),
                },
                new User
                {
                    GroupId = 26,
                    Start = new DateTime(2022, 4, 2, 20, 0, 0),
                    End = new DateTime(2022, 4, 2, 20, 59, 59),
                },
                 new User
                 {
                     GroupId = 27,
                     Start = new DateTime(2022, 4, 3, 8, 0, 0),
                     End = new DateTime(2022, 4, 3, 8, 59, 59),
                 },
                new User
                {
                    GroupId = 28,
                    Start = new DateTime(2022, 4, 3, 9, 0, 0),
                    End = new DateTime(2022, 4, 3, 9, 59, 59),
                },
                new User
                {
                    GroupId = 29,
                    Start = new DateTime(2022, 4, 3, 10, 0, 0),
                    End = new DateTime(2022, 4, 3, 10, 59, 59),
                },
                new User
                {
                    GroupId = 30,
                    Start = new DateTime(2022, 4, 3, 11, 0, 0),
                    End = new DateTime(2022, 4, 3, 11, 59, 59),
                },
                new User
                {
                    GroupId = 31,
                    Start = new DateTime(2022, 4, 3, 12, 0, 0),
                    End = new DateTime(2022, 4, 3, 12, 59, 59),
                },
                new User
                {
                    GroupId = 32,
                    Start = new DateTime(2022, 4, 3, 13, 0, 0),
                    End = new DateTime(2022, 4, 3, 13, 59, 59),
                },
                new User
                {
                    GroupId = 33,
                    Start = new DateTime(2022, 4, 3, 14, 0, 0),
                    End = new DateTime(2022, 4, 3, 14, 59, 59),
                },
                new User
                {
                    GroupId = 34,
                    Start = new DateTime(2022, 4, 3, 15, 0, 0),
                    End = new DateTime(2022, 4, 3, 15, 59, 59),
                }, new User
                {
                    GroupId = 35,
                    Start = new DateTime(2022, 4, 3, 16, 0, 0),
                    End = new DateTime(2022, 4, 3, 16, 59, 59),
                }, new User

                {
                    GroupId = 36,
                    Start = new DateTime(2022, 4, 3, 17, 0, 0),
                    End = new DateTime(2022, 4, 3, 17, 59, 59),
                },
                new User
                {
                    GroupId = 37,
                    Start = new DateTime(2022, 4, 3, 18, 0, 0),
                    End = new DateTime(2022, 4, 3, 18, 59, 59),
                },
                new User
                {
                    GroupId = 38,
                    Start = new DateTime(2022, 4, 3, 19, 0, 0),
                    End = new DateTime(2022, 4, 3, 19, 59, 59),
                },
                new User
                {
                    GroupId = 39,
                    Start = new DateTime(2022, 4, 3, 20, 0, 0),
                    End = new DateTime(2022, 4, 3, 20, 59, 59),
                },
                 new User
                 {
                     GroupId = 40,
                     Start = new DateTime(2022, 4, 4, 8, 0, 0),
                     End = new DateTime(2022, 4, 4, 8, 59, 59),
                 },
                new User
                {
                    GroupId = 41,
                    Start = new DateTime(2022, 4, 4, 9, 0, 0),
                    End = new DateTime(2022, 4, 4, 9, 59, 59),
                },
                new User
                {
                    GroupId = 42,
                    Start = new DateTime(2022, 4, 4, 10, 0, 0),
                    End = new DateTime(2022, 4, 4, 10, 59, 59),
                },
                new User
                {
                    GroupId = 43,
                    Start = new DateTime(2022, 4, 4, 11, 0, 0),
                    End = new DateTime(2022, 4, 4, 11, 59, 59),
                },
                new User
                {
                    GroupId = 44,
                    Start = new DateTime(2022, 4, 4, 12, 0, 0),
                    End = new DateTime(2022, 4, 4, 12, 59, 59),
                },
                new User
                {
                    GroupId = 45,
                    Start = new DateTime(2022, 4, 4, 13, 0, 0),
                    End = new DateTime(2022, 4, 4, 13, 59, 59),
                },
                new User
                {
                    GroupId = 46,
                    Start = new DateTime(2022, 4, 4, 14, 0, 0),
                    End = new DateTime(2022, 4, 4, 14, 59, 59),
                },
                new User
                {
                    GroupId = 47,
                    Start = new DateTime(2022, 4, 4, 15, 0, 0),
                    End = new DateTime(2022, 4, 4, 15, 59, 59),
                }, new User
                {
                    GroupId = 48,
                    Start = new DateTime(2022, 4, 4, 16, 0, 0),
                    End = new DateTime(2022, 4, 4, 16, 59, 59),
                }, new User

                {
                    GroupId = 49,
                    Start = new DateTime(2022, 4, 4, 17, 0, 0),
                    End = new DateTime(2022, 4, 4, 17, 59, 59),
                },
                new User
                {
                    GroupId = 50,
                    Start = new DateTime(2022, 4, 4, 18, 0, 0),
                    End = new DateTime(2022, 4, 4, 18, 59, 59),
                },
                new User
                {
                    GroupId = 51,
                    Start = new DateTime(2022, 4, 4, 19, 0, 0),
                    End = new DateTime(2022, 4, 4, 19, 59, 59),
                },
                new User
                {
                    GroupId = 52,
                    Start = new DateTime(2022, 4, 4, 20, 0, 0),
                    End = new DateTime(2022, 4, 4, 20, 59, 59),
                },
                 new User
                 {
                     GroupId = 53,
                     Start = new DateTime(2022, 4, 5, 8, 0, 0),
                     End = new DateTime(2022, 4, 5, 8, 59, 59),
                 },
                new User
                {
                    GroupId = 54,
                    Start = new DateTime(2022, 4, 5, 9, 0, 0),
                    End = new DateTime(2022, 4, 5, 9, 59, 59),
                },
                new User
                {
                    GroupId = 55,
                    Start = new DateTime(2022, 4, 5, 10, 0, 0),
                    End = new DateTime(2022, 4, 5, 10, 59, 59),
                },
                new User
                {
                    GroupId = 56,
                    Start = new DateTime(2022, 4, 5, 11, 0, 0),
                    End = new DateTime(2022, 4, 5, 11, 59, 59),
                },
                new User
                {
                    GroupId = 57,
                    Start = new DateTime(2022, 4, 5, 12, 0, 0),
                    End = new DateTime(2022, 4, 5, 12, 59, 59),
                },
                new User
                {
                    GroupId = 58,
                    Start = new DateTime(2022, 4, 5, 13, 0, 0),
                    End = new DateTime(2022, 4, 5, 13, 59, 59),
                },
                new User
                {
                    GroupId = 59,
                    Start = new DateTime(2022, 4, 5, 14, 0, 0),
                    End = new DateTime(2022, 4, 5, 14, 59, 59),
                },
                new User
                {
                    GroupId = 60,
                    Start = new DateTime(2022, 4, 5, 15, 0, 0),
                    End = new DateTime(2022, 4, 5, 15, 59, 59),
                }, new User
                {
                    GroupId = 61,
                    Start = new DateTime(2022, 4, 5, 16, 0, 0),
                    End = new DateTime(2022, 4, 5, 16, 59, 59),
                }, new User

                {
                    GroupId = 62,
                    Start = new DateTime(2022, 4, 5, 17, 0, 0),
                    End = new DateTime(2022, 4, 5, 17, 59, 59),
                },
                new User
                {
                    GroupId = 63,
                    Start = new DateTime(2022, 4, 5, 18, 0, 0),
                    End = new DateTime(2022, 4, 5, 18, 59, 59),
                },
                new User
                {
                    GroupId = 64,
                    Start = new DateTime(2022, 4, 5, 19, 0, 0),
                    End = new DateTime(2022, 4, 5, 19, 59, 59),
                },
                new User
                {
                    GroupId = 65,
                    Start = new DateTime(2022, 4, 5, 20, 0, 0),
                    End = new DateTime(2022, 4, 5, 20, 59, 59),
                },
                 new User
                 {
                     GroupId = 66,
                     Start = new DateTime(2022, 4, 6, 8, 0, 0),
                     End = new DateTime(2022, 4, 6, 8, 59, 59),
                 },
                new User
                {
                    GroupId = 67,
                    Start = new DateTime(2022, 4, 6, 9, 0, 0),
                    End = new DateTime(2022, 4, 6, 9, 59, 59),
                },
                new User
                {
                    GroupId = 68,
                    Start = new DateTime(2022, 4, 6, 10, 0, 0),
                    End = new DateTime(2022, 4, 6, 10, 59, 59),
                },
                new User
                {
                    GroupId = 69,
                    Start = new DateTime(2022, 4, 6, 11, 0, 0),
                    End = new DateTime(2022, 4, 6, 11, 59, 59),
                },
                new User
                {
                    GroupId = 70,
                    Start = new DateTime(2022, 4, 6, 12, 0, 0),
                    End = new DateTime(2022, 4, 6, 12, 59, 59),
                },
                new User
                {
                    GroupId = 71,
                    Start = new DateTime(2022, 4, 6, 13, 0, 0),
                    End = new DateTime(2022, 4, 6, 13, 59, 59),
                },
                new User
                {
                    GroupId = 72,
                    Start = new DateTime(2022, 4, 6, 14, 0, 0),
                    End = new DateTime(2022, 4, 6, 14, 59, 59),
                },
                new User
                {
                    GroupId = 73,
                    Start = new DateTime(2022, 4, 6, 15, 0, 0),
                    End = new DateTime(2022, 4, 6, 15, 59, 59),
                }, new User
                {
                    GroupId = 74,
                    Start = new DateTime(2022, 4, 6, 16, 0, 0),
                    End = new DateTime(2022, 4, 6, 16, 59, 59),
                }, new User

                {
                    GroupId = 75,
                    Start = new DateTime(2022, 4, 6, 17, 0, 0),
                    End = new DateTime(2022, 4, 6, 17, 59, 59),
                },
                new User
                {
                    GroupId = 76,
                    Start = new DateTime(2022, 4, 6, 18, 0, 0),
                    End = new DateTime(2022, 4, 6, 18, 59, 59),
                },
                new User
                {
                    GroupId = 77,
                    Start = new DateTime(2022, 4, 6, 19, 0, 0),
                    End = new DateTime(2022, 4, 6, 19, 59, 59),
                },
                new User
                {
                    GroupId = 78,
                    Start = new DateTime(2022, 4, 6, 20, 0, 0),
                    End = new DateTime(2022, 4, 6, 20, 59, 59),
                },
                 new User
                 {
                     GroupId = 79,
                     Start = new DateTime(2022, 4, 7, 8, 0, 0),
                     End = new DateTime(2022, 4, 7, 8, 59, 59),
                 },
                new User
                {
                    GroupId = 80,
                    Start = new DateTime(2022, 4, 7, 9, 0, 0),
                    End = new DateTime(2022, 4, 7, 9, 59, 59),
                },
                new User
                {
                    GroupId = 81,
                    Start = new DateTime(2022, 4, 7, 10, 0, 0),
                    End = new DateTime(2022, 4, 7, 10, 59, 59),
                },
                new User
                {
                    GroupId = 82,
                    Start = new DateTime(2022, 4, 7, 11, 0, 0),
                    End = new DateTime(2022, 4, 7, 11, 59, 59),
                },
                new User
                {
                    GroupId = 83,
                    Start = new DateTime(2022, 4, 7, 12, 0, 0),
                    End = new DateTime(2022, 4, 7, 12, 59, 59),
                },
                new User
                {
                    GroupId = 84,
                    Start = new DateTime(2022, 4, 7, 13, 0, 0),
                    End = new DateTime(2022, 4, 7, 13, 59, 59),
                },
                new User
                {
                    GroupId = 85,
                    Start = new DateTime(2022, 4, 7, 14, 0, 0),
                    End = new DateTime(2022, 4, 7, 14, 59, 59),
                },
                new User
                {
                    GroupId = 86,
                    Start = new DateTime(2022, 4, 7, 15, 0, 0),
                    End = new DateTime(2022, 4, 7, 15, 59, 59),
                }, new User
                {
                    GroupId = 87,
                    Start = new DateTime(2022, 4, 7, 16, 0, 0),
                    End = new DateTime(2022, 4, 7, 16, 59, 59),
                }, new User

                {
                    GroupId = 88,
                    Start = new DateTime(2022, 4, 7, 17, 0, 0),
                    End = new DateTime(2022, 4, 7, 17, 59, 59),
                },
                new User
                {
                    GroupId = 89,
                    Start = new DateTime(2022, 4, 7, 18, 0, 0),
                    End = new DateTime(2022, 4, 7, 18, 59, 59),
                },
                new User
                {
                    GroupId = 90,
                    Start = new DateTime(2022, 4, 7, 19, 0, 0),
                    End = new DateTime(2022, 4, 7, 19, 59, 59),
                },
                new User
                {
                    GroupId = 91,
                    Start = new DateTime(2022, 4, 7, 20, 0, 0),
                    End = new DateTime(2022, 4, 7, 20, 59, 59)
                }
            );
        }
    }
}

