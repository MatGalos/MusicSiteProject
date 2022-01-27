using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Track;
using MusicSite.Models.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums
{
    public class ShowAlbum
    {
        public ShowAlbum(Album album)
        {
            this.ID = album.ID;
            this.artistName = album.artistName;
            this.albumName = album.albumName;
            this.albumReviews = album.albumReviews;
            this.albumTrackList = album.albumTrackList;
            this.releaseDate = album.releaseDate;
            this.reviewCount = album.albumReviews.Count();

        }
       
        [HiddenInput]
        public String ID { get; set; }
        public string albumName { get; set; }
        public DateTime releaseDate { get; set; }
        public int reviewCount { get;  set; }
        public int averageRating { get; set; }
        public string artistName { get; set; }
        public IEnumerable<TrackDB> albumTrackList { get; set; }
        public ICollection<Review> albumReviews { get; set; }
        [HiddenInput]
        public string ReturnURL { get; set; }
    }
    
}
