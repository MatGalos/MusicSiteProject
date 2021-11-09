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
        static List<User> listOfUsers = new List<User>() //dummy data
        {
            new User()
            {
                name="Mateusz",lastName="Galos", userName="Magick99",
                Id=0,password="sdjhgf92vlsQ!",creationDate=DateTime.Parse("1999-09-22"),
                eMail="mag99@spoko.pl", numberOfReviews=10, accountCreationDate=DateTime.Now,
                
            },
            new User()
            {
                name="Alan",lastName="Galos", userName="Magick99",
                Id=1,password="sdjhgf92vlsQ!",creationDate=DateTime.Parse("1999-09-22"),
                eMail="mag99@spoko.pl", numberOfReviews=10, accountCreationDate=DateTime.Now,

            }
        };
        static int counter = listOfUsers.Count();
        public IActionResult Index()
        {
            return View();
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
                listOfUsers.Add(u);
                counter++;
                return View("UserList", listOfUsers);
            }
            else
            {
                return View("AddForm");
            }
        }
        public IActionResult UserListView() //for seeing list of users
        {
            return View("UserList", listOfUsers);
        }
        public IActionResult DeleteUser(int Id) //For deleting user
        {
            listOfUsers.Remove(listOfUsers.First(a => a.Id == Id));
            return View("UserList", listOfUsers);
        }
        public IActionResult ModifyUser(int Id) //For modyfing user
        {
            User mod = listOfUsers.Find(x => x.Id == Id);
            return View("ModifyUser",mod);
        }

        public IActionResult ModifyUserList(User u)
        {
            User a = listOfUsers.First(x => x.Id == u.Id);
            User c = new User()
            {
                name = a.name,
                lastName = a.lastName,
                userName = u.userName,
                Id = a.Id,
                password = u.password,
                creationDate = a.creationDate,
                eMail = u.eMail,
                numberOfReviews = a.numberOfReviews,
                accountCreationDate = a.accountCreationDate,
            };
            listOfUsers.Remove(listOfUsers.First(a => a.Id == c.Id));
            listOfUsers.Insert(c.Id, c);
            return View("UserList", listOfUsers);
        }
    }
}
