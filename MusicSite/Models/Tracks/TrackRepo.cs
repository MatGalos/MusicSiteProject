using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicSite.Models.Tracks;
using MusicSite.Models.Track;

namespace MusicSite.Models.Tracks
{
    public class TrackRepo:ITrack
    {
        private readonly AppDataBase db;
        public TrackRepo(AppDataBase db)
        {
            this.db = db;
        }

        public TrackDB TrackData(string AlbumID, int TrackNumberInAlbum, string TrackTitle, string TrackLength)
        {
            TrackDB entity = this.db.Tracks.FirstOrDefault(a => a.AlbumID == AlbumID && a.TrackNumberInAlbum==TrackNumberInAlbum &&a.TrackTitle==TrackTitle&&a.TrackLength==TrackLength);

            if (entity == null)
            {
                entity = new TrackDB()
                {
                    AlbumID = AlbumID,
                    TrackNumberInAlbum = TrackNumberInAlbum,
                    TrackTitle = TrackTitle,
                    TrackLength = TrackLength
                };
                db.Tracks.Add(entity);
            }
            db.SaveChanges();
            return entity;
        }
    }
}
