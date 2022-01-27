using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        public ReviewShow Get(String ReviewId,String UserID)
        {
            ReviewShow entity = this.db.Reviews
                .Include(a => a.author)
                .Where(a => a.ID == ReviewId)
                .Select(a => new ReviewShow(a, UserID))
                .FirstOrDefault();
            return entity;
        }
    }
}
