using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums.AlbumsRepository
{
    public partial class AlbumRepository : IAlbum
    {
        private readonly AppDataBase db;

        public AlbumRepository(AppDataBase db)
        {
            this.db = db;
        }
    }
}
