using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        public int CountUserReviews(string userID)
        {
            return this.db.Reviews
                .Where(a => a.userID == userID)
                .Count();
        }
    }
}
