using Microsoft.AspNetCore.Mvc;
using static MusicSite.Models.Album;

namespace MusicSite.Models
{
    public class AlbumController : Controller
    {
        private readonly Album album;
        public AlbumController(Album album)
        {
            this.album = album;
        }

    }
}
