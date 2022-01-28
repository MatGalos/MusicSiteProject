using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Reviews;

namespace MusicSite.Models.Albums
{
    public class AlbumController : Controller
    {
        private readonly IAlbum album;
        private readonly IReview review;
        private readonly UserManager<User> user;
        public AlbumController(IAlbum album,UserManager<User> user,IReview review)
        {
            this.album = album;
            this.user = user;
            this.review = review;
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
            return View("ViewAlbum", album.Get(id, user.GetUserId(User)));
        }

    }
}
