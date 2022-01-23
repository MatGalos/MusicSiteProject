using Microsoft.AspNetCore.Mvc;
using MusicSite.Models;
using MusicSite.Models.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult SingleAlbum(int id)
        {
            return View(model:repository.SingleAlbum(id));
        }
    }
}
