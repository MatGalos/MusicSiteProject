using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MusicSite.Models.Tracks;
using MusicSite.Extended;

namespace MusicSite.Models
{
    public class Album
    {
        [Key]
        public String ID { get; set; }
        [Required(ErrorMessage = "Musisz podać tytuł albumu")]
        public string albumName { get; set; }
        [Required(ErrorMessage = "Musisz podać datę wydania")]
        public DateTime releaseDate { get; set; }
        [Required(ErrorMessage = "Musisz podać artystę")]
        public string artistName { get; set; }
        public IEnumerable<Track> albumTrackList { get; set; } = new List<Track>();
        public ICollection<Review> albumReviews { get; set; } = new List<Review>();

        public static void ModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(a => a.ID)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Album>()
                .HasData(StaticData.Albums);
        }
    }
}
