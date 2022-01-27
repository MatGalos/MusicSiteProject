using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums.AlbumsRepository
{
    public partial class AlbumRepository : IAlbum
    {
        public ShowAlbum Get(string ID)
        {
            ShowAlbum entity = this.db.Albums
                        .Include(a => a.albumTrackList)
                        .Include(a => a.albumReviews)
                        .Where(a => a.ID == ID)
                        .FirstOrDefault();
            return entity;
        }
    }
}
