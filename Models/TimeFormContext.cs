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

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    CategoryID = 4,
                    Title = "Dark Knight Rises",
                    Year = 2012,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""

                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryID = 4,
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""


                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryID = 4,
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""


                }
            );
        }
    }
}

