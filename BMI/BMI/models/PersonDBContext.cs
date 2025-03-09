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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(FileSystem.AppDataDirectory, "Database.db");
            optionsBuilder
                .UseSqlite($"Filename={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // To DO
        }
    }
}
