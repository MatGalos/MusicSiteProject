using MusicSite.Models.Track;
using MusicSite.Models.Tracks;
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
        IQueryable<TrackDB> Tracks { get; }
    }
    public class Ef :IDB
    {
        private readonly AppDataBase context;    
        public Ef(AppDataBase context)
        {
            this.context = context;
        }
        public IQueryable<User> Users => context.Users;
        public IQueryable<Album> Albums => context.Albums;
        public IQueryable<Review> Reviews => context.Reviews;
        public IQueryable<TrackDB> Tracks => context.Tracks;
    }
}
