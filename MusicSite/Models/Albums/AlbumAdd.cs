using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums
{
    public class AlbumAdd
    {
        [Required]
        [HiddenInput]
        public string ID { get; set; }
        public string albumName { get;  set; }
        public string artistName { get;  set; }
        [DataType(DataType.Date)]
        public DateTime releaseDate { get; internal set; }
    }
}
