using Microsoft.AspNetCore.Mvc;
using MusicSite.Models.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews
{
    public class ReviewUpdate
    {
        [HiddenInput]
        [Required(ErrorMessage = "Wystąpił problem proszę poczekać")]
        public string ID { get; set; }
        public ShowUserModel Author { get; set; }
        [HiddenInput]
        public String ReturnURL { get; set; }
        public string reviewText { get; internal set; }
        [HiddenInput]
        public string albumID { get; internal set; }
        [Required]
        [Range(0, 5, ErrorMessage = "Ocena spoza zakresu")]
        public int rating { get; internal set; }
    }
}
