using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using MusicSite.Extended;
using MusicSite.Models.Albums;

namespace MusicSite.Models.Track
{
    public class TrackDB
    {   
        [Key]
        public string ID { get; set; } 
        public int TrackNumberInAlbum { get; set; }
        public string TrackTitle { get; set; }
        public string TrackLength { get; set; }
        public string AlbumID { get; set; }
        public Album Album;

        internal static void ModelCreate(ModelBuilder builder)
        {
            builder.Entity<TrackDB>()
                .Property(a => a.ID)
                .HasDefaultValueSql("NEWID()");

            builder.Entity<TrackDB>()
                .HasOne(a => a.Album)
                .WithMany(a => a.albumTrackList)
                .HasForeignKey(a => a.AlbumID);

            builder.Entity<TrackDB>()
               .HasData(Info.Tracks);
        }
        
    }

    public interface ICRUDTrackRepository
    {
        TrackDB Find(int id);
        TrackDB Delete(int id);
        TrackDB Add(TrackDB track);
        TrackDB Update(TrackDB track);
        IList<TrackDB> FindAll();
    }
    public class CRUDTrackRepository : ICRUDTrackRepository
    {
        public TrackDB Add(TrackDB track)
        {
            throw new NotImplementedException();
        }

        public TrackDB Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TrackDB Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TrackDB> FindAll()
        {
            throw new NotImplementedException();
        }

        public TrackDB Update(TrackDB track)
        {
            throw new NotImplementedException();
        }
    }
}
