using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicSite.Models
{
    public class AppDataBase:DbContext
    {
        public AppDataBase(DbContextOptions<AppDataBase> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
