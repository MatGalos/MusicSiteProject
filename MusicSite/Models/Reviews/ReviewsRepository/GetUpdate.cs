using MusicSite.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        public ReviewUpdate GetUpdate(string ReviewID, string UserID)
        {
            ReviewUpdate entity = this.db.Reviews
                .Where(a => a.ID == ReviewID)
                .Select(a => new ReviewUpdate()
                {
                    ID = a.ID,
                    rating=a.rating,
                    albumID=a.albumID,
                    reviewText = a.reviewText,
                    Author = new ShowUserModel(a.author, UserID)
                }).FirstOrDefault();
            return entity;
        }

    }
}
