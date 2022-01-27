using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview 
    {
        public Review Add(Review review)
        {
            Review entity = this.db.Reviews.Add(review).Entity;
            this.db.SaveChanges();
            return entity;
        }
    }
}
