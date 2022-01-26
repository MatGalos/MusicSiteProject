using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MusicSite.Models
{
    public class AppDataBase : IdentityDbContext<User>
    {
        
        public AppDataBase(DbContextOptions<AppDataBase> options) : base(options) { }
        //public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; } 
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<Track>().ToTable("Track");
        }
    }
}
