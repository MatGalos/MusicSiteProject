using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums.AlbumsRepository
{
    public partial class AlbumRepository : IAlbum
    {
        public int CountPages()
        {
            return (int)Math.Ceiling((this.db.Albums.Count() / (Single)IAlbum.PerPage) - 1);
        }
    }
}
