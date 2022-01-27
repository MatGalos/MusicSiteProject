using MusicSite.Models;
using MusicSite.Models.Login;
using MusicSite.Models.Tracks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Extended
{
    public class StaticData
    {
        public static readonly string path = Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).Parent.Parent.FullName;

        public static readonly IReadOnlyList<User> users = new List<User>
        {
            new User()
            {
                Name="Mateusz",
                LastName="Galos",
                UserName="MAgick90909",
                PasswordHash="Pass1234!",
                Email="mateuszgalos@gmail.com",
                CreationDate=new DateTime(1999,09,22),
                Id="123dsad-adsasasd"
            }
        };
        public static readonly IReadOnlyList<User> admins = new List<User>
        {
            new User()
            {
                Name="Admin",
                LastName="Admin",
                UserName="Admin",
                PasswordHash="Pass1234!",
                Email="Admin@gmail.com",
                CreationDate=new DateTime(1999,09,22),
                Id="113dsad-adsasasd"
            }
        };
        public static readonly IReadOnlyDictionary<String, String> roleID = new Dictionary<String, String> {
            { Roles.Admin,"hdfsgkjhaskdhadsfk"},
            { Roles.User,"asdapsoid[pias"}
        };

        public static readonly IReadOnlyList<Track> Tracks = new List<Track>
        {

        };
    }
}
