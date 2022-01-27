using MusicSite.Models;
using MusicSite.Models.Login;
using MusicSite.Models.Track;
using MusicSite.Models.Tracks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Extended
{
    public class Info
    {
        public static readonly string path = Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).Parent.Parent.FullName;

        public static readonly IReadOnlyList<User> users = new List<User>
        {
            new User()
            {
                Name="Mateusz",
                LastName="Galos",
                UserName="MAgick90909",
                PasswordHash="AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==",
                Email="mateuszgalos@gmail.com",
                CreationDate=new DateTime(1999,09,22),
                Id="1"
            }
        };
        public static readonly IReadOnlyList<User> admins = new List<User>
        {
            new User()
            {
                Name="Admin",
                LastName="Admin",
                UserName="Admin",
                NormalizedUserName = "ADMIN",
                PasswordHash="AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==",
                Email="Admin@gmail.com",
                CreationDate=new DateTime(1999,09,22),
                Id="113dsad-adsasasd"
            }
        };
        public static readonly IReadOnlyDictionary<String, String> roleID = new Dictionary<String, String> {
            { Roles.Admin,"hdfsgkjhaskdhadsfk"},
            { Roles.User,"asdapsoid[pias"}
        };
        public static readonly IReadOnlyList<TrackDB> Tracks = new List<TrackDB> {
            new TrackDB()
            {
                ID="1",
                AlbumID="1",
                TrackNumberInAlbum=1,
                TrackLength="0:19",
                TrackTitle="Intro"

            }
        };

        public static readonly IReadOnlyList<Review> Reviews = new List<Review> { 
            new Review()
            {
                ID="1",
                albumID="1",
                userID="1",
                rating=5,
                reviewText="Good"
            }
        };
        public static readonly IReadOnlyList<Album> Albums = new List<Album> {
            new Album()
            {
                ID="1",
                albumName="The College Dropout",
                releaseDate=new DateTime(2004,02,10),
                artistName="Kanye West"
            }
        };
    }
}
