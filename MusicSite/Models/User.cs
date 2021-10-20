using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class User //Klasa User do której stworzenia potrzeba imie nazwisko nazwa użytkownika data urodzenia adres email, automatycznie serwer aktualizuję datę stworzenia, liczbę recenzji, liczbę komentarzy oraz średnią wystawionych ocen
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Podaj imię")]
        public string name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string lastName { get; set; }
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage ="Hasło nie spełnia wymogów bezpieczeństwa")]
        [Required(ErrorMessage ="Podaj Hasło")]
        public string password { get; set; }
        [Required(ErrorMessage = "Podaj nazwę użytkownika")]
        public string userName { get; set; }
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}",ErrorMessage ="E-Mail nie spełnia wymogów adresu e-mail")]
        [Required(ErrorMessage = "Podaj adres email")]
        public string eMail { get; set; }
        [Required(ErrorMessage = "Podaj datę urodzenia")]
        public DateTime creationDate { get; set; }
        public int numberOfReviews { get; set; }
        public DateTime accountCreationDate { get; set; }
        /*public enum levelOfAccount
        {
            Free=1,
            Premium=2,
            VIP=3,
            Artist=4,
            Moderator=5,
            Admin=6
        }*/
    }
}
