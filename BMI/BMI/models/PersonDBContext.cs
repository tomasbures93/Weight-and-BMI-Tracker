using BMI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.models
{
    public class PersonDBContext : DbContext
    {
        public DbSet<User> Personen { get; set; }

        public DbSet<Weight> Weights { get; set; }

        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new { ID = 1 , Name = "User", Weight = 75.0, Height = 175.0, DateOfBirth = "1.1.1111", Gender = "Male", });
        }
    }
}
