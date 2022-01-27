using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview 
    {
        public Review Add(ReviewAdd review,string authorID)
        {
            Review newEntity = new()
            {
                userID = authorID,
                ID = new Guid().ToString(),
                albumID = review.albumID,
                rating = review.rating,
                reviewText = review.reviewText
            };
            Review entity = this.db.Reviews.Add(newEntity).Entity;
            this.db.SaveChanges();
            return entity;
        }
    }
}
