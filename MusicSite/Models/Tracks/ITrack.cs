using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Tracks
{
    public interface ITrack
    {
        public Track TrackData(string AlbumID, int TrackNumberInAlbum, string TrackTitle, string TrackLength);
    }
}
