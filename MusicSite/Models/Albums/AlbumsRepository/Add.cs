using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums.AlbumsRepository
{
    public partial class AlbumRepository : IAlbum
    {
        public Album Add(AlbumAdd albumAdd)
        {
            Album album = new()
            {
                albumName=albumAdd.albumName,
                artistName=albumAdd.artistName,
                releaseDate=albumAdd.releaseDate
            };

            Album album1 = this.db.Albums.Add(album).Entity;
            this.db.SaveChanges();
            return album1;
        }
    }
}
