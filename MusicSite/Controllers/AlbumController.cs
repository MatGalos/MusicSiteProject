using Microsoft.AspNetCore.Mvc;
using static MusicSite.Models.Album;

namespace MusicSite.Models
{
    public class AlbumController : Controller
    {
        private ICRUDAlbumRepository repository;
        public AlbumController(ICRUDAlbumRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index1()
        {
            return View(repository.FindAll());
        }
        public IActionResult Index(int page=0)
        {
            if (page <= 0)
                page = 0;
            var entities = repository.GetPage(page);
            if (entities.Count <= 0)
            {
                page = 0;
                entities = repository.GetPage(page);
            }
            ViewData["page"] = page;
            return View("index", model: entities);
        }
        public IActionResult SingleAlbum(string id)
        {
            return View("ViewAlbum",repository.SingleAlbum(id));
        }
    }
}
