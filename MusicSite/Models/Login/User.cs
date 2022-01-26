using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public enum levelOfAccount
        {
            user,
            admin,
        }
    public class User : IdentityUser //Klasa User do której stworzenia potrzeba imie nazwisko nazwa użytkownika data urodzenia adres email, automatycznie serwer aktualizuję datę stworzenia, liczbę recenzji, liczbę komentarzy oraz średnią wystawionych ocen
    {

        [Required(ErrorMessage ="Podaj imię")]
        public string name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Podaj datę urodzenia")]
        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }
        public ICollection<Review> userReviews { get; set; }
        [DataType(DataType.Date)]
        public DateTime accountCreationDate { get; set; } = DateTime.Now;
        

        public interface ICRUDUserRepository
        {
            User Add(User user);
            User Update(User user);
            IList<User> FindAll();
        }
        public class CRUDUserRepository : ICRUDUserRepository
        {
            private AppDataBase _context;

            public CRUDUserRepository(AppDataBase context)
            {
                _context = context;
            }
            public User Add(User user)
            {
                var entity = _context.Users.Add(user).Entity;
                _context.SaveChanges();
                return entity;

            }

            public IList<User> FindAll()
            {
                List<User> entity = _context.Users.ToList();
                return entity;
            }

            public User Update(User user)
            {
                var entity = _context.Users.Update(user).Entity;
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
