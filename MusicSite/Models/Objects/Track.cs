using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicSite.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }
        public int TrackNumberInAlbum { get; set; }
        public string trackTitle { get; set; }
        public int trackLength { get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }

        internal static void ModelCreate(ModelBuilder builder)
        {
            builder.Entity<Track>()
                .HasOne(a => a.Album)
                .WithMany(a => a.albumTrackList)
                .HasForeignKey(a => a.AlbumID);
        }
    }
}
