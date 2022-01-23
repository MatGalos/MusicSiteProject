using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public interface IDB
    {
        IQueryable<User> Users { get; }
        IQueryable<Review> Reviews { get; }
        IQueryable<Album> Albums { get; }
        IQueryable<Track> Tracks { get; }
    }
    public class EF :IDB
    {
        private AppDataBase context;    
        public EF(AppDataBase context)
        {
            this.context = context;
        }
        public IQueryable<User> Users => context.Users;
        public IQueryable<Album> Albums => context.Albums;
        public IQueryable<Review> Reviews => context.Reviews;
        public IQueryable<Track> Tracks => context.Tracks;
    }
}
