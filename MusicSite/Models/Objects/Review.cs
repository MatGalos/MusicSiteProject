using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int albumID { get; set; }
        public int userID { get; set; }
        public byte rating { get; set; }
        public string reviewText { get; set; }
    }
}
