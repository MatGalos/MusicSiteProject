﻿using Microsoft.AspNetCore.Mvc;
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
    public class User //Klasa User do której stworzenia potrzeba imie nazwisko nazwa użytkownika data urodzenia adres email, automatycznie serwer aktualizuję datę stworzenia, liczbę recenzji, liczbę komentarzy oraz średnią wystawionych ocen
    {
        [Key]
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Podaj imię")]
        public string name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string lastName { get; set; }
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage ="Hasło nie spełnia wymogów bezpieczeństwa")]
        [Required(ErrorMessage ="Podaj Hasło")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "Podaj nazwę użytkownika")]
        public string userName { get; set; }
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}",ErrorMessage ="E-Mail nie spełnia wymogów adresu e-mail")]
        [Required(ErrorMessage = "Podaj adres email")]
        public string eMail { get; set; }
        [Required(ErrorMessage = "Podaj datę urodzenia")]
        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }
        public ICollection<Review> userReviews { get; set; }
        [DataType(DataType.Date)]
        public DateTime accountCreationDate { get; set; } = DateTime.Now;
        public levelOfAccount levelOfAccount { get; set; }
        

        public interface ICRUDUserRepository
        {
            User Find(int id);
            User Delete(int id);
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

            public User Delete(int id)
            {
                User user = _context.Users.Remove(_context.Users.FirstOrDefault(a => a.Id == id)).Entity;
                _context.SaveChanges();
                return user;
            }

            public User Find(int id)
            {
                User entity=_context.Users.FirstOrDefault(a => a.Id == id);
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
