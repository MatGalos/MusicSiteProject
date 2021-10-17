using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models
{
    public class User //Klasa User do której stworzenia potrzeba imie nazwisko nazwa użytkownika data urodzenia adres email, automatycznie serwer aktualizuję datę stworzenia, liczbę recenzji, liczbę komentarzy oraz średnią wystawionych ocen
    {
        [Required(ErrorMessage ="Podaj imię")]
        public string name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string lastName { get; set; }
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Podaj adres email")]
        public string eMail { get; set; }
        [Required(ErrorMessage = "Podaj datę urodzenia")]
        public DateTime creationDate { get; set; }
        public int numberOfReviews { get; set; }
    }
}
