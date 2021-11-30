using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class Track
    {
        public int ID { get; set; }
        public string trackTitle { get; set; }
        public int trackLength { get; set; }
    }
}
