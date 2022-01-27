using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums.AlbumsRepository
{
    public partial class AlbumRepository : IAlbum
    {
        public IList<Album> GetPage(int Page, int perPage = 10)
        {
            List<Album> entities = this.db.Albums.OrderBy(a => a.ID).Skip(Page * perPage).Take(perPage).ToList();
            return entities;
        }
    }
}
