using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews.ReviewsRepository
{
    public partial class ReviewRepository : IReview
    {
        public void Delete(string ID)
        {
            db.Reviews.Remove(this.db.Reviews.FirstOrDefault(a => a.ID == ID));
            db.SaveChanges();
        }
    }
}
