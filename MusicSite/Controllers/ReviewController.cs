using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MusicSite.Models.Review;

namespace MusicSite.Models
{
    public class ReviewController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IReview repository;
        public ReviewController(IReview repository, UserManager<User> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }
        

        [HttpGet]
        [Authorize]
        public IActionResult Add(string id)
        {
            return this.View(new ReviewAdd(){
                albumID=id
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(ReviewAdd reviewAdd)
        {
            if (this.ModelState.IsValid)
            {
                repository.Add(reviewAdd, userManager.GetUserId(this.User));

                return this.RedirectToAction("Index", "Album", new { albumId = reviewAdd.albumID });
            }
            else return this.View();
        }


    }
}
