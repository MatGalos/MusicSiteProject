using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Login
{
    public class RegisterModel
    {
        [Display(Name = "Imie")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string LastName { get; set; }
        [Display(Name = "Nazwa użytkownika")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string UserName { get; set; }
        [Display(Name = "Hasło")]
        [UIHint("password")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        [EmailAddress(ErrorMessage = "Niepoprawny Email")]
        public string EMail { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public DateTime CreationDate { get; set; }
        [HiddenInput]
        public String ReturnUrl { get; set; }
    }
}
