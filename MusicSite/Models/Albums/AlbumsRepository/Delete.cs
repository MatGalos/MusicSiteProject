using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums.AlbumsRepository
{
    public partial class AlbumRepository : IAlbum
    {
        public Album Delete(string ID)
        {
            Album data = this.db.Albums.FirstOrDefault(a => a.ID == ID);
            db.Albums.Remove(data);
            db.SaveChanges();
            return data;
        }
    }
}
