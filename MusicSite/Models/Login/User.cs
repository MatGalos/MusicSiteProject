using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MusicSite.Extended;
using MusicSite.Models.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MusicSite.Models
{
    public enum LevelOfAccount
        {
            user,
            admin,
        }
    public class User : IdentityUser //Klasa User do której stworzenia potrzeba imie nazwisko nazwa użytkownika data urodzenia adres email, automatycznie serwer aktualizuję datę stworzenia, liczbę recenzji, liczbę komentarzy oraz średnią wystawionych ocen
    {

        [Required(ErrorMessage ="Podaj imię")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Podaj datę urodzenia")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public ICollection<Review> UserReviews { get; set; }
        [DataType(DataType.Date)]
        public DateTime AccountCreationDate { get; set; } = DateTime.Now;

        
        public static void ModelCreate(ModelBuilder builder)
        {
            static void AddUser(ModelBuilder builder,User entity,String roleID)
            {
                builder.Entity<User>().HasData(entity);
                builder.Entity<IdentityUserRole<String>>.HasData(
                    new IdentityUserRole<String>
                    {
                        RoleId = roleID,
                        UserId = entity.Id
                    }
                    );

            }
            foreach (FieldInfo p in typeof(Roles).GetFields())
            {
                string role = (String)p.GetValue(null);
                builder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = StaticData.roleID[role],
                    Name = role
                });
            }

            foreach (User entity in StaticData.users)
            {
                AddUser(builder, entity, StaticData.roleID[Roles.User]);
            }

            foreach (User entity in StaticData.admins)
            {
                AddUser(builder, entity, StaticData.roleID[Roles.Admin]);
            }
        }
       
        
    }
}
