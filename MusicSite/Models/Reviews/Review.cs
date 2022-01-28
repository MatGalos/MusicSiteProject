using Microsoft.EntityFrameworkCore;
using MusicSite.Extended;
using MusicSite.Models.Albums;
using MusicSite.Models.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews
{
    public class Review
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string albumID { get; set; }
        [Required]
        public String userID { get; set; }
        public User author { get; set; }
        public Album album { get; set; }
        [Required]
        [Range(0, 5, ErrorMessage = "Ocena spoza zakresu")]
        public int rating { get; set; }
        public string reviewText { get; set; }


        internal static void ModelCreate(ModelBuilder builder)
        {
            builder.Entity<Review>()
                .Property(a => a.ID)
                .HasDefaultValueSql("NEWID()");

            builder.Entity<Review>().HasData(Info.Reviews);

            builder.Entity<Review>()
                .HasOne(a => a.author)
                .WithMany(a => a.UserReviews)
                .HasForeignKey(a => a.userID);

            builder.Entity<Review>()
                .HasOne(a => a.album)
                .WithMany(a => a.albumReviews)
                .HasForeignKey(a => a.albumID);

        }
    }
}
