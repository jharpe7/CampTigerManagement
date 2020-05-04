using System;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;
using CampTiger.Data;
namespace CampTiger.Models{
    public class ApplicationDbContext: DbContext {
        public DbSet<Member> Members {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options){ }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<Member>().HasData(
                new{
                    MemberId = 0001,
                    FirstName = "Peter",
                    LastName = "Griffin",
                    Password = "password0001",
                    DOB = "07/29/1999",
                    Address = "9090 York Rd ",
                    City = "Towson",
                    State = "MD"
                },
                new{
                    MemberId = 0007,
                    FirstName = "Mark",
                    LastName = "Zuckerberg",
                    Password = "password0007",
                    DOB = "10/20/1979",
                    Address = "9090 York Rd ",
                    City = "Towson",
                    State = "MD"
                }
            
            );
        }
    }
}