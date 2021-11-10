using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class ReviewController : Controller
    {
        private IReviewRepository repository;
        public ReviewController(IReviewRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index1()
        {
            return View(repository.Reviews);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
