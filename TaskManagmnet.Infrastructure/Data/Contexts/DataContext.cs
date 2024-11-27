using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagmnet.Domain.Entities;
using TaskManagmnet.Infrastructure.Data.Configurations;

namespace TaskManagmnet.Infrastructure.Data.Contexts
{
    public class DataContext : DbContext
    {
        public string DbPath { get; set; }

        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            string path = Directory.GetCurrentDirectory();
            string dataDirectory = Path.Combine(path,"Database");

            DbPath = Path.Combine(dataDirectory,"Tasks.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Job> Jobs { get; set; }
    }
}