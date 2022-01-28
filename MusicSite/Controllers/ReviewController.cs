using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Login;
using MusicSite.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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

        [HttpGet]
        [Authorize]
        public IActionResult Update(string id,string URL)
        {
            ReviewUpdate data = repository.GetUpdate(id, userManager.GetUserId(this.User));
            data.ReturnURL = URL;
            return data.Author.ItsMe ? this.View(model: data):this.StatusCode(403);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Update(ReviewUpdate reviewUpdate)
        {
            if (this.ModelState.IsValid)
            {
                if (!repository.GetUpdate(reviewUpdate.ID, userManager.GetUserId(this.User)).Author.ItsMe) 
                    return this.StatusCode(403);
                repository.Update(reviewUpdate);
                return this.Redirect(reviewUpdate?.ReturnURL ?? "/");
            }
            else
            {
                return this.View();
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(string id,string URL)
        {
            ReviewShow reviewShow = repository.Get(id, userManager.GetUserId(this.User));
            reviewShow.ReturnURL = URL;
            return reviewShow.Author.ItsMe ? this.View(model: reviewShow) : this.StatusCode(403);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(string id)
        {
            if (this.ModelState.IsValid)
            {
                ReviewShow review = repository.Get(id,userManager.GetUserId(this.User));
                if (!review.Author.ItsMe )
                {
                    return this.StatusCode(403);
                }
                repository.Delete(id);
                return this.RedirectToAction("Index", "Album");
            }
            else
            {
                return this.View();
            }
        }

        [HttpGet]
        [Authorize(Roles.Admin)]
        public IActionResult DeleteByAdmin(string id, string URL)
        {
            ReviewShow reviewShow = repository.Get(id, userManager.GetUserId(this.User));
            reviewShow.ReturnURL = URL;
            return this.View(model: reviewShow);
        }

        [HttpPost]
        [Authorize(Roles.Admin)]
        public IActionResult DeleteByAdmin(string id)
        {
            if (this.ModelState.IsValid)
            {
                ReviewShow review = repository.Get(id, "");
                repository.Delete(id);
                return this.RedirectToAction("Index", "Album");
            }
            else
            {
                return this.View();
            }
        }
    }
}
