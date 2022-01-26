using Microsoft.AspNetCore.Mvc;
using MusicSite.Models;
using static MusicSite.Models.User;

namespace MusicSite.Controllers
{
    public class UserController : Controller
    {
        private ICRUDUserRepository repository;
        public UserController(ICRUDUserRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index1()
        {
            return View(repository.FindAll());
        }

        public IActionResult Index()
        {
            return View("UserList", repository.FindAll());
        }
        public IActionResult AddForm()
        {
            return View();
        }
        public IActionResult RecieveUser(User u) //adding new user through the form if it's wrong it come back to form with info about wrong data, if it's correct it should 
                                                 //inform about successfuly creating account.
        {
            if (ModelState.IsValid)
            {
                repository.Add(u);
                return View("UserList", repository.FindAll());
            }
            else
            {
                return View("AddForm");
            }
        }
        public IActionResult UserListView() //for seeing list of users
        {
            return View("UserList", repository.FindAll());
        }
        public IActionResult DeleteUser(int Id) //For deleting user
        {
            repository.Delete(Id);
            return View("UserList", repository.FindAll());
        }
        [HttpGet]
        public IActionResult ModifyUser(int Id) //For finding user to modify
        {
            User mod = repository.Find(Id);
            return View(model:mod);
        }
        [HttpPost]
        public IActionResult ModifyUser(User u) //For modyfing user
        {
            if (ModelState.IsValid)
            { 
                repository.Update(u);
                return UserListView();
            }
            else return View("ModifyUser");
        }
    }
}
