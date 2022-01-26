
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace MusicSite.Models.Login
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Podaj nazwę użytkownika")]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Podaj Hasło")]
        [Display(Name = "Hasło")]
        [UIHint("Password")]
        public string Password { get; set; }
        [HiddenInput]
        public string ReturnURL { get; set; } = "/";
    }
}
