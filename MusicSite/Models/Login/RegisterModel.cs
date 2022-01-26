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
        [Key]
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Imie")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string name { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string lastName { get; set; }
        [Display(Name = "Nazwa użytkownika")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string userName { get; set; }
        [Display(Name = "Hasło")]
        [UIHint("password")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public string password { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        [EmailAddress(ErrorMessage = "Niepoprawny Email")]
        public string eMail { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Musisz uzupełnić pole")]
        public DateTime creationDate { get; set; }
        [HiddenInput]
        public String ReturnUrl { get; set; }
    }
}
