using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicSite.Models.Tracks;

namespace MusicSite.Models
{
    public class AppDataBase : IdentityDbContext<User>
    {
        
        public AppDataBase(DbContextOptions<AppDataBase> options) : base(options) { }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; } 
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            User.ModelCreate(modelBuilder);
            Track.ModelCreate(modelBuilder);
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Album>().ToTable("Album");
        }
    }
}
