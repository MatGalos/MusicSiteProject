using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class EFUserRepository :IUserRepository, IAlbumRepository,IReviewRepository
    {
        private AppDataBase context;    
        public EFUserRepository(AppDataBase context)
        {
            this.context = context;
        }
        public IQueryable<User> Users => context.Users;
        public IQueryable<Album> Albums => context.Albums;
        public IQueryable<Review> Reviews => context.Reviews;
    }
}
