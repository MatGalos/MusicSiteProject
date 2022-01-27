using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Reviews
{
    public class ReviewAdd
    {
        [Required]
        [HiddenInput]
        public String albumID { get; set; }

        [Display(Name ="Ocena")]
        [Required(ErrorMessage ="Nie można zostawić pustej oceny")]
        [Range(0, 5, ErrorMessage = "Ocena spoza zakresu")]
        public byte rating { get; set; }
        public string reviewText { get; set; }
    }
}
