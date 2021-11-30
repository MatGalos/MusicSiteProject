using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public interface IAlbumRepository
    {
        IQueryable<Album> Albums { get; }
    }
}
