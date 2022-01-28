using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Reviews;
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
        public ShowAlbum(Album album, string userID)
        {
            this.ID = album.ID;
            this.artistName = album.artistName;
            this.albumName = album.albumName;
            this.albumTrackList = album.albumTrackList;
            this.releaseDate = album.releaseDate;
            this.reviewCount = album.albumReviews.Count();
            this.averageRating = album.albumReviews.Where(a => a.albumID == album.ID).Average(a => a.rating);

            this.albumTrackList = album.albumTrackList;
            this.albumReviews = album.albumReviews.Select(a => new ReviewShow(a, userID));
        }

      
       
        [HiddenInput]
        public String ID { get; set; }
        public string albumName { get; set; }
        public DateTime releaseDate { get; set; }
        public int reviewCount { get;  set; }
        public double averageRating { get; set; }
        public string artistName { get; set; }
        public IEnumerable<TrackDB> albumTrackList { get; set; }
        public IEnumerable<ReviewShow> albumReviews { get; set; }
        [HiddenInput]
        public string ReturnURL { get; set; }
    }
    
}
