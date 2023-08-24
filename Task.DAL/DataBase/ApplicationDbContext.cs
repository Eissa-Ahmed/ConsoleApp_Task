using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Configuration;
using Task.DAL.Entity;

namespace Task.DAL.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Data Source = ESSA-AHMED; Integrated Security = True; Initial Catalog = Simba; Trust Server Certificate = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Account");
            UserConfiguration userConfiguration = new UserConfiguration();
            PostConfiguration postConfiguration = new PostConfiguration();
            modelBuilder.ApplyConfiguration(userConfiguration);
            modelBuilder.ApplyConfiguration(postConfiguration);
        }
        public DbSet<Users> users { get; set; }
        public DbSet<Posts> posts { get; set; }
        public DbSet<Comments> comments { get; set; }
    }
}
