using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        public Review Update(ReviewUpdate reviewUpdate)
        {
            Review review = db.Reviews.FirstOrDefault(a => a.ID == reviewUpdate.ID);
                review.rating = reviewUpdate.rating;
                review.reviewText = reviewUpdate.reviewText;

                db.Reviews.Update(review);
                db.SaveChanges();
                return review;
        }
    }
}
