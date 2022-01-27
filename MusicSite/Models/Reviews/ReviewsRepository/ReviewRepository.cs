using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        private readonly AppDataBase db;

        public ReviewRepository(AppDataBase db)
        {
            this.db = db;
        }
    }
}
