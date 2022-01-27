using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        public int CountAlbumReviews(string albumID)
        {
            return this.db.Reviews
                .Where(a => a.albumID == albumID)
                .Count();
        }
    }
}
