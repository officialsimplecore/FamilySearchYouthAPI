using FamilySearchYouthAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FamilySearchYouthAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>()
                .HasMany(c => c.RegionalInformation);
            // To-do: Make sure to register a foreign key with RegionalInformation when you use an IDE
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionalInformation> RegionalInformation { get; set; }
    }
}
