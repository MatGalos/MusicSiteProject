using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Albums
{
    public interface IAlbum
    {
        public Album Add(AlbumAdd albumAdd);
        public int CountPages();
        public Album Delete(string ID);
        public ShowAlbum Get(string ID, string userID);
        public IList<Album> GetPage(int Page, int perPage = 10);
        public static int PerPage { get; set; } = 10;
    }
}
