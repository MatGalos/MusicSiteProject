using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MusicSite.Models.Review;

namespace MusicSite.Models
{
    public class ReviewController : Controller
    {
        private ICRUDReviewRepository repository;
        public ReviewController(ICRUDReviewRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index1()
        {
            return View(repository.FindAll());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
