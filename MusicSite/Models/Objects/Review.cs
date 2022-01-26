using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class Review
    {
        public int ID { get; set; }
        [Required]
        public int albumID { get; set; }
        [Required]
        public String userID { get; set; }
        [ForeignKey("userID")]
        public User author { get; set; }
        [ForeignKey("albumID")]
        public Album album { get; set; }
        [Required]
        [Range(0, 5, ErrorMessage = "Ocena spoza zakresu")]
        public byte rating { get; set; }
        public string reviewText { get; set; }


        internal static void ModelCreate(ModelBuilder builder)
        {
            builder.Entity<Review>()
                .HasOne(a => a.author)
                .WithMany(a => a.userReviews)
                .HasForeignKey(a => a.userID);

            builder.Entity<Review>()
                .HasOne(a => a.album)
                .WithMany(a => a.albumReviews)
                .HasForeignKey(a => a.albumID);

            builder.Entity<Review>()
                .HasKey(a => new { a.albumID, a.userID });
        }

        public interface ICRUDReviewRepository 
        {
            Review Find(int id);
            Review Delete(int id);
            Review Add(Review review);
            Review Update(Review review);
            IList<Review> FindAll();
            IList<Review> FindForAlbum();
            IList<Review> FindForUser();
            IList<Review> GetPage(int Page, int perPage = 5);
            Review SingleReview(int id);
        }

        public class CRUDReviewRepository : ICRUDReviewRepository
        {
            private AppDataBase _context;
            public CRUDReviewRepository(AppDataBase context)
            {
                this._context = context;
            }
            public Review Add(Review review)
            {
                Review entity = _context.Reviews.Add(review).Entity;
                _context.SaveChanges();
                return entity;
            }

            public Review Delete(int id)
            {
                Review entity = _context.Reviews.Remove(_context.Reviews.FirstOrDefault(a => a.ID == id)).Entity;
                return entity;
            }

            public Review Find(int id)
            {
                Review entity = _context.Reviews.FirstOrDefault(a => a.ID == id);
                return entity;
            }

            public IList<Review> FindAll()
            {
                List<Review> entity = _context.Reviews.ToList();
                return entity;
            }

            public IList<Review> FindForAlbum()
            {
                throw new NotImplementedException();
            }

            public IList<Review> FindForUser()
            {
                throw new NotImplementedException();
            }

            public IList<Review> GetPage(int Page, int perPage = 5)
            {
                List<Review> entity = _context.Reviews.OrderBy(a => a.ID).Skip(Page * perPage).Take(perPage).ToList();
                return entity;
            }

            public Review SingleReview(int id)
            {
                throw new NotImplementedException();
            }

            public Review Update(Review review)
            {
                Review entity = _context.Reviews.Update(review).Entity;
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
