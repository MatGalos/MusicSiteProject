using Microsoft.AspNetCore.Mvc;
using MusicSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Controllers
{
    public class UserController : Controller
    {
        static List<User> listOfUsers = new List<User>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddForm()
        {
            return View();
        }
        public IActionResult RecieveUser(User u)
        {
            if (ModelState.IsValid)
            {
                listOfUsers.Add(u);
                return View("UserList", listOfUsers);
            }
            else
            {
                return View("AddForm");
            }
        }
    }
}
