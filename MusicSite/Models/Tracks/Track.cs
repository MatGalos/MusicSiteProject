using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using MusicSite.Extended;

namespace MusicSite.Models.Tracks
{
    public class Track
    {
        public int TrackNumberInAlbum { get; set; }
        public string TrackTitle { get; set; }
        public string TrackLength { get; set; }
        public string AlbumID { get; set; }
        [ForeignKey("AlbumID")]
        public Album Album;

        internal static void ModelCreate(ModelBuilder builder)
        {
            builder.Entity<Track>().HasKey(a => new { a.AlbumID });
            foreach(Track entity in StaticData.Tracks)
            {
                builder.Entity<Track>().HasData(entity);
            }
            builder.Entity<Track>()
                .HasOne(a => a.Album)
                .WithMany(a => a.albumTrackList)
                .HasForeignKey(a => a.AlbumID);
        }
        public interface ICRUDTrackRepository
        {
            Track Find(int id);
            Track Delete(int id);
            Track Add(Track track);
            Track Update(Track track);
            IList<Track> FindAll();
        }
        public class CRUDTrackRepository : ICRUDTrackRepository
        {
            public Track Add(Track track)
            {
                throw new NotImplementedException();
            }

            public Track Delete(int id)
            {
                throw new NotImplementedException();
            }

            public Track Find(int id)
            {
                throw new NotImplementedException();
            }

            public IList<Track> FindAll()
            {
                throw new NotImplementedException();
            }

            public Track Update(Track track)
            {
                throw new NotImplementedException();
            }
        }
    }
}
