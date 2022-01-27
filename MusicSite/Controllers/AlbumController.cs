using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Albums;
using MusicSite.Models.Albums.AlbumsRepository;
using static MusicSite.Models.Album;

namespace MusicSite.Models
{
    public class AlbumController : Controller
    {
        private readonly IAlbum album;
        private readonly UserManager<User> user;
        public AlbumController(IAlbum album,UserManager<User> user)
        {
            this.album = album;
            this.user = user;
        }

        public IActionResult Index(int page=0)
        {
            if (page <= 0)
                page = 0;
            var entities = album.GetPage(page);
            if (entities.Count <= 0)
            {
                page = 0;
                entities = album.GetPage(page);
            }
            ViewData["page"] = page;
            return View("index", model: entities);
        }

        public IActionResult SingleAlbum(string id)
        {
            return View("ViewAlbum", album.Get(id));
        }

    }
}
