using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int userID { get; set; }
        public User author { get; set; }
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
        
        }
    }
}
