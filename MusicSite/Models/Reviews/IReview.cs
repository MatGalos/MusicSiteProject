using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews
{
    public interface IReview
    {
        public Review Add(Review review);
        public int CountAlbumReviews(string albumID);
        public int CountUserReviews(string userID);
        public void Delete(string ID);
        public ReviewShow Get(String ReviewId, String UserID);
        public ReviewUpdate GetUpdate(string ReviewID, string UserID);
        public Review Update(ReviewUpdate reviewUpdate);
    }
}
