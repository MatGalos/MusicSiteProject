using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MusicSite.Models.Tracks;
using MusicSite.Extended;
using MusicSite.Models.Track;

namespace MusicSite.Models
{
    public class Album
    {
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage = "Musisz podać tytuł albumu")]
        public string albumName { get; set; }

        [Required(ErrorMessage = "Musisz podać datę wydania")]
        public DateTime releaseDate { get; set; }
        [Required(ErrorMessage = "Musisz podać artystę")]
        public string artistName { get; set; }

        public IEnumerable<TrackDB> albumTrackList { get; set; } = new List<TrackDB>();
        public ICollection<Review> albumReviews { get; set; } = new List<Review>();

        public static void ModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(a => a.ID)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Album>()
                .HasData(Info.Albums);
        }
    }
}
