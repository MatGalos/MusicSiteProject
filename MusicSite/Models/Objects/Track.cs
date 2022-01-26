using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSite.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }
        public int TrackNumberInAlbum { get; set; }
        public string trackTitle { get; set; }
        public string trackLength { get; set; }
        public int AlbumID { get; set; }
        [ForeignKey("AlbumID")]
        public Album Album { get; set; }

        internal static void ModelCreate(ModelBuilder builder)
        {
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
