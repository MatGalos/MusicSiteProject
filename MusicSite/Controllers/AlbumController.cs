using Microsoft.AspNetCore.Mvc;
using MusicSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class AlbumController : Controller
    {
        private IAlbumRepository repository;
        public AlbumController(IAlbumRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index1()
        {
            return View(repository.Albums);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
