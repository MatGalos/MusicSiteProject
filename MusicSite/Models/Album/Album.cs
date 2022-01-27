using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using static MusicSite.Models.Track;
using Microsoft.EntityFrameworkCore;

namespace MusicSite.Models
{
    public class Album
    {
        [Key]
        public String ID { get; set; }
        public string albumName { get; set; }
        public DateTime releaseDate { get; set; }
        public string artistName { get; set; }
        public ICollection<Track> albumTrackList { get; set; } = new List<Track>();
        public ICollection<Review> albumReviews { get; set; } = new List<Review>();



        public interface ICRUDAlbumRepository
        {
            Album Find(string id);
            Album Delete(string id);
            Album Add(Album album);
            Album Update(Album album);
            IList<Album> FindAll();
            IList<Album> GetPage(int Page, int perPage = 10);
            Album SingleAlbum(string id);
        }
        public class CRUDAlbumRepository : ICRUDAlbumRepository
        {
            private AppDataBase _context;

            public CRUDAlbumRepository(AppDataBase context)
            {
                _context = context;
            }

            public Album Add(Album album)
            {
                var entity = _context.Albums.Add(album).Entity;
                _context.SaveChanges();
                return entity;
            }

            public Album Delete(string id)
            {
                var user = _context.Albums.Remove(Find(id)).Entity;
                _context.SaveChanges();
                return user;
            }

            public Album Find(string id)
            {
                return _context.Albums.Find(id);
            }


            public IList<Album> FindAll()
            {
                return _context.Albums.ToList();
            }

            public IList<Album> GetPage(int Page, int perPage = 10)
            {
                List<Album> entities = _context.Albums.OrderBy(a => a.ID).Skip(Page * perPage).Take(perPage).ToList();
                return entities;
            }

            public Album Update(Album album)
            {
                var entity = _context.Albums.Update(album).Entity;
                _context.SaveChanges();
                return entity;
            }

            public Album SingleAlbum(string id)
            {
                Album entity = _context.Albums
                    .Include(a=>a.albumTrackList)
                    .Include(a=>a.albumReviews)
                    .Where(a => a.ID == id)
                    .FirstOrDefault();
;
                return entity;
            }

        }
    }
}
