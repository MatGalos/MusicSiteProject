using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using static MusicSite.Models.Track;

namespace MusicSite.Models
{
    public class Album
    {
        [HiddenInput]
        public int ID { get; set; }
        public string albumName { get; set; }
        public DateTime releaseDate { get; set; }
        public string artistName { get; set; }
        public ICollection<Track> albumTrackList { get; set; } = new List<Track>();
        public ICollection<Review> albumReviews { get; set; } = new List<Review>();
    }
}
