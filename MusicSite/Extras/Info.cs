using MusicSite.Models;
using MusicSite.Models.Albums;
using MusicSite.Models.Login;
using MusicSite.Models.Reviews;
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
                NormalizedUserName="MAGICK90909",
                PasswordHash="AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==",
                Email="mateuszgalos@gmail.com",
                CreationDate=new DateTime(1999,09,22),
                Id=Guid.NewGuid().ToString()
            },
            new User()
            {
                Name="Stefan",
                LastName="Stefanowy",
                UserName="User2",
                NormalizedUserName="USER2",
                PasswordHash="AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==",
                Email="user2@gmail.com",
                CreationDate=new DateTime(1997,07,22),
                Id=Guid.NewGuid().ToString()
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
                Id=Guid.NewGuid().ToString()
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

            },
            new TrackDB()
            {
                ID="2",
                AlbumID="1",
                TrackNumberInAlbum=2,
                TrackLength="3:59",
                TrackTitle="We Don't Care"
            },
            new TrackDB()
            {
                ID="3",
                AlbumID="1",
                TrackNumberInAlbum=3,
                TrackLength="1:22",
                TrackTitle="Graduation Day"
            },
            new TrackDB()
            {
                ID="4",
                AlbumID="1",
                TrackNumberInAlbum=4,
                TrackLength="3:43",
                TrackTitle="All Falls Down"
            },
            new TrackDB()
            {
                ID="5",
                AlbumID="1",
                TrackNumberInAlbum=5,
                TrackLength="1:09",
                TrackTitle="I will Fly Away"
            },
            new TrackDB()
            {
                ID="6",
                AlbumID="1",
                TrackNumberInAlbum=6,
                TrackLength="5:24",
                TrackTitle="Spaceship"
            },
            new TrackDB()
            {
                ID="7",
                AlbumID="1",
                TrackNumberInAlbum=7,
                TrackLength="3:13",
                TrackTitle="Jesus Walks"
            },
            new TrackDB()
            {
                ID="8",
                AlbumID="1",
                TrackNumberInAlbum=8,
                TrackLength="5:24",
                TrackTitle="Never Let Me Down"
            },
            new TrackDB()
            {
                ID="9",
                AlbumID="1",
                TrackNumberInAlbum=9,
                TrackLength="4:49",
                TrackTitle="Get Em High"
            },
            new TrackDB()
            {
                ID="10",
                AlbumID="1",
                TrackNumberInAlbum=10,
                TrackLength="0:46",
                TrackTitle="Workout Plan"
            },
            new TrackDB()
            {
                ID="11",
                AlbumID="1",
                TrackNumberInAlbum=11,
                TrackLength="5:22",
                TrackTitle="The New Workout Plan"
            },
            new TrackDB()
            {
                ID="12",
                AlbumID="1",
                TrackNumberInAlbum=12,
                TrackLength="5:16",
                TrackTitle="Slow Jamz"
            },
            new TrackDB()
            {
                ID="13",
                AlbumID="1",
                TrackNumberInAlbum=13,
                TrackLength="4:06",
                TrackTitle="Breathe In Breathe Out"
            },
            new TrackDB()
            {
                ID="14",
                AlbumID="1",
                TrackNumberInAlbum=14,
                TrackLength="1:18",
                TrackTitle="School Spirit Skit 1"
            },
            new TrackDB()
            {
                ID="15",
                AlbumID="1",
                TrackNumberInAlbum=15,
                TrackLength="3:02",
                TrackTitle="School Spirit"
            },
            new TrackDB()
            {
                ID="16",
                AlbumID="1",
                TrackNumberInAlbum=16,
                TrackLength="0:43",
                TrackTitle="School Spirit Skit 2"
            },
            new TrackDB()
            {
                ID="17",
                AlbumID="1",
                TrackNumberInAlbum=17,
                TrackLength="0:53",
                TrackTitle="Lil Jimmy Skit"
            },
            new TrackDB()
            {
                ID="18",
                AlbumID="1",
                TrackNumberInAlbum=18,
                TrackLength="4:26",
                TrackTitle="Two Words"
            },
            new TrackDB()
            {
                ID="19",
                AlbumID="1",
                TrackNumberInAlbum=19,
                TrackLength="3:41",
                TrackTitle="Through the Wire"
            },
            new TrackDB()
            {
                ID="20",
                AlbumID="1",
                TrackNumberInAlbum=20,
                TrackLength="4:38",
                TrackTitle="Family Business"
            },
            new TrackDB()
            {
                ID="21",
                AlbumID="1",
                TrackNumberInAlbum=21,
                TrackLength="12:40",
                TrackTitle="Last Call"
            },
            new TrackDB()
            {
                ID="22",
                AlbumID="2",
                TrackNumberInAlbum=1,
                TrackLength="0:41",
                TrackTitle="Wake Up Mr. West"
            },
            new TrackDB()
            {
                ID="23",
                AlbumID="2",
                TrackNumberInAlbum=2,
                TrackLength="3:25",
                TrackTitle="Heard Em Say"
            },
            new TrackDB()
            {
                ID="24",
                AlbumID="2",
                TrackNumberInAlbum=3,
                TrackLength="3:56",
                TrackTitle="Touch the Sky"
            },
            new TrackDB()
            {
                ID="25",
                AlbumID="2",
                TrackNumberInAlbum=4,
                TrackLength="3:27",
                TrackTitle="Gold Digger"
            },
            new TrackDB()
            {
                ID="26",
                AlbumID="2",
                TrackNumberInAlbum=5,
                TrackLength="0:33",
                TrackTitle="Skit #1"
            },
            new TrackDB()
            {
                ID="27",
                AlbumID="2",
                TrackNumberInAlbum=6,
                TrackLength="4:32",
                TrackTitle="Drive Slow"
            },
            new TrackDB()
            {
                ID="28",
                AlbumID="2",
                TrackNumberInAlbum=7,
                TrackLength="1:43",
                TrackTitle="My Way Home"
            },
            new TrackDB()
            {
                ID="29",
                AlbumID="2",
                TrackNumberInAlbum=8,
                TrackLength="4:31",
                TrackTitle="Crack Music"
            },
            new TrackDB()
            {
                ID="30",
                AlbumID="2",
                TrackNumberInAlbum=9,
                TrackLength="4:05",
                TrackTitle="Roses"
            },
            new TrackDB()
            {
                ID="31",
                AlbumID="2",
                TrackNumberInAlbum=10,
                TrackLength="3:19",
                TrackTitle="Bring Me Down"
            },
            new TrackDB()
            {
                ID="32",
                AlbumID="2",
                TrackNumberInAlbum=11,
                TrackLength="4:27",
                TrackTitle="Addiction"
            },
            new TrackDB()
            {
                ID="33",
                AlbumID="2",
                TrackNumberInAlbum=12,
                TrackLength="0:31",
                TrackTitle="Skit #2"
            },
            new TrackDB()
            {
                ID="34",
                AlbumID="2",
                TrackNumberInAlbum=13,
                TrackLength="3:53",
                TrackTitle="Diamonds From Sierra Leone (Remix)"
            },
            new TrackDB()
            {
                ID="35",
                AlbumID="2",
                TrackNumberInAlbum=14,
                TrackLength="7:28",
                TrackTitle="We Major"
            },
            new TrackDB()
            {
                ID="36",
                AlbumID="2",
                TrackNumberInAlbum=15,
                TrackLength="0:24",
                TrackTitle="Skit #3"
            },
            new TrackDB()
            {
                ID="37",
                AlbumID="2",
                TrackNumberInAlbum=16,
                TrackLength="5:05",
                TrackTitle="Hey Mama"
            },
            new TrackDB()
            {
                ID="38",
                AlbumID="2",
                TrackNumberInAlbum=17,
                TrackLength="3:18",
                TrackTitle="Celebration"
            },
            new TrackDB()
            {
                ID="39",
                AlbumID="2",
                TrackNumberInAlbum=18,
                TrackLength="1:19",
                TrackTitle="Skit #4"
            },
            new TrackDB()
            {
                ID="40",
                AlbumID="2",
                TrackNumberInAlbum=19,
                TrackLength="5:32",
                TrackTitle="Gone"
            },
            new TrackDB()
            {
                ID="41",
                AlbumID="2",
                TrackNumberInAlbum=20,
                TrackLength="3:58",
                TrackTitle="Diamonds From Sierra Leone [bonus track]"
            },
            new TrackDB()
            {
                ID="42",
                AlbumID="2",
                TrackNumberInAlbum=21,
                TrackLength="3:50",
                TrackTitle="Late"
            },
            new TrackDB()
            {
                ID="43",
                AlbumID="3",
                TrackNumberInAlbum=1,
                TrackLength="3:15",
                TrackTitle="Good Morning"
            },
new TrackDB()
            {
                ID="44",
                AlbumID="3",
                TrackNumberInAlbum=2,
                TrackLength="2:48",
                TrackTitle="Champion"
            },
new TrackDB()
            {
                ID="45",
                AlbumID="3",
                TrackNumberInAlbum=3,
                TrackLength="5:12",
                TrackTitle="Stronger"
            },
new TrackDB()
            {
                ID="46",
                AlbumID="3",
                TrackNumberInAlbum=4,
                TrackLength="4:03",
                TrackTitle="I Wonder"
            },
new TrackDB()
            {
                ID="47",
                AlbumID="3",
                TrackNumberInAlbum=5,
                TrackLength="3:27",
                TrackTitle="Good Life"
            },
new TrackDB()
            {
                ID="48",
                AlbumID="3",
                TrackNumberInAlbum=6,
                TrackLength="4:32",
                TrackTitle="Cant Tell Me Nothing"
            },
new TrackDB()
            {
                ID="49",
                AlbumID="3",
                TrackNumberInAlbum=7,
                TrackLength="3:24",
                TrackTitle="Barry Bonds"
            },
new TrackDB()
            {
                ID="50",
                AlbumID="3",
                TrackNumberInAlbum=8,
                TrackLength="3:24",
                TrackTitle="Drunk and Hot Girls"
            },
new TrackDB()
            {
                ID="51",
                AlbumID="3",
                TrackNumberInAlbum=9,
                TrackLength="3:58",
                TrackTitle="Flashing Lights"
            },
new TrackDB()
            {
                ID="52",
                AlbumID="3",
                TrackNumberInAlbum=10,
                TrackLength="3:48",
                TrackTitle="Everything I Am"
            },
new TrackDB()
            {
                ID="53",
                AlbumID="3",
                TrackNumberInAlbum=11,
                TrackLength="3:33",
                TrackTitle="The Glory"
            },
new TrackDB()
            {
                ID="54",
                AlbumID="3",
                TrackNumberInAlbum=12,
                TrackLength="3:24",
                TrackTitle="Homecoming"
            },
new TrackDB()
            {
                ID="55",
                AlbumID="3",
                TrackNumberInAlbum=13,
                TrackLength="4:47",
                TrackTitle="Big Brother"
            },
new TrackDB()
            {
                ID="56",
                AlbumID="4",
                TrackNumberInAlbum=1,
                TrackLength="6:18",
                TrackTitle="Say You Will"
            },
new TrackDB()
            {
                ID="57",
                AlbumID="4",
                TrackNumberInAlbum=2,
                TrackLength="4:23",
                TrackTitle="Welcome to Heartbreak"
            },
new TrackDB()
            {
                ID="58",
                AlbumID="4",
                TrackNumberInAlbum=3,
                TrackLength="3:31",
                TrackTitle="Heartless"
            },
new TrackDB()
            {
                ID="59",
                AlbumID="4",
                TrackNumberInAlbum=4,
                TrackLength="3:58",
                TrackTitle="Amazing"
            },
new TrackDB()
            {
                ID="60",
                AlbumID="4",
                TrackNumberInAlbum=5,
                TrackLength="4:30",
                TrackTitle="Love Lockdown"
            },
new TrackDB()
            {
                ID="61",
                AlbumID="4",
                TrackNumberInAlbum=6,
                TrackLength="4:38",
                TrackTitle="Paranoid"
            },
new TrackDB()
            {
                ID="62",
                AlbumID="4",
                TrackNumberInAlbum=7,
                TrackLength="4:34",
                TrackTitle="RoboCop"
            },
new TrackDB()
            {
                ID="63",
                AlbumID="4",
                TrackNumberInAlbum=8,
                TrackLength="3:10",
                TrackTitle="Street Lights"
            },
new TrackDB()
            {
                ID="64",
                AlbumID="4",
                TrackNumberInAlbum=9,
                TrackLength="3:59",
                TrackTitle="Bad News"
            },
new TrackDB()
            {
                ID="65",
                AlbumID="4",
                TrackNumberInAlbum=10,
                TrackLength="4:18",
                TrackTitle="See You in My Nightmares"
            },
new TrackDB()
            {
                ID="66",
                AlbumID="4",
                TrackNumberInAlbum=11,
                TrackLength="2:44",
                TrackTitle="Coldest Winter"
            },
new TrackDB()
            {
                ID="67",
                AlbumID="5",
                TrackNumberInAlbum=1,
                TrackLength="4:40",
                TrackTitle="Dark Fantasy"
            },
new TrackDB()
            {
                ID="68",
                AlbumID="5",
                TrackNumberInAlbum=2,
                TrackLength="5:57",
                TrackTitle="Gorgeous"
            },
new TrackDB()
            {
                ID="69",
                AlbumID="5",
                TrackNumberInAlbum=3,
                TrackLength="4:52",
                TrackTitle="Power"
            },
new TrackDB()
            {
                ID="70",
                AlbumID="5",
                TrackNumberInAlbum=4,
                TrackLength="1:02",
                TrackTitle="All of the Lights (Interlude)"
            },
new TrackDB()
            {
                ID="71",
                AlbumID="5",
                TrackNumberInAlbum=5,
                TrackLength="4:59",
                TrackTitle="All of the Lights"
            },
new TrackDB()
            {
                ID="72",
                AlbumID="5",
                TrackNumberInAlbum=6,
                TrackLength="6:18",
                TrackTitle="Monster"
            },
new TrackDB()
            {
                ID="73",
                AlbumID="5",
                TrackNumberInAlbum=7,
                TrackLength="6:38",
                TrackTitle="So Appalled"
            },
new TrackDB()
            {
                ID="74",
                AlbumID="5",
                TrackNumberInAlbum=8,
                TrackLength="5:52",
                TrackTitle="Devil in a New Dress"
            },
new TrackDB()
            {
                ID="75",
                AlbumID="5",
                TrackNumberInAlbum=9,
                TrackLength="9:08",
                TrackTitle="Runaway"
            },
new TrackDB()
            {
                ID="76",
                AlbumID="5",
                TrackNumberInAlbum=10,
                TrackLength="5:27",
                TrackTitle="Hell of a Life"
            },
new TrackDB()
            {
                ID="77",
                AlbumID="5",
                TrackNumberInAlbum=11,
                TrackLength="7:49",
                TrackTitle="Blame Game"
            },
new TrackDB()
            {
                ID="78",
                AlbumID="5",
                TrackNumberInAlbum=12,
                TrackLength="4:16",
                TrackTitle="Lost in the World"
            },
new TrackDB()
            {
                ID="79",
                AlbumID="5",
                TrackNumberInAlbum=13,
                TrackLength="1:38",
                TrackTitle="Who Will Survive in America"
            },
new TrackDB()
            {
                ID="80",
                AlbumID="6",
                TrackNumberInAlbum=1,
                TrackLength="2:37",
                TrackTitle="On Sight"
            },
new TrackDB()
            {
                ID="81",
                AlbumID="6",
                TrackNumberInAlbum=2,
                TrackLength="3:08",
                TrackTitle="Black Skinhead"
            },
new TrackDB()
            {
                ID="82",
                AlbumID="6",
                TrackNumberInAlbum=3,
                TrackLength="3:52",
                TrackTitle="I Am a God"
            },
new TrackDB()
            {
                ID="83",
                AlbumID="6",
                TrackNumberInAlbum=4,
                TrackLength="4:16",
                TrackTitle="New Slaves"
            },
new TrackDB()
            {
                ID="84",
                AlbumID="6",
                TrackNumberInAlbum=5,
                TrackLength="5:27",
                TrackTitle="Hold My Liquor"
            },
new TrackDB()
            {
                ID="85",
                AlbumID="6",
                TrackNumberInAlbum=6,
                TrackLength="3:55",
                TrackTitle="Im in It"
            },
new TrackDB()
            {
                ID="86",
                AlbumID="6",
                TrackNumberInAlbum=7,
                TrackLength="6:00",
                TrackTitle="Blood on the Leaves"
            },
new TrackDB()
            {
                ID="87",
                AlbumID="6",
                TrackNumberInAlbum=8,
                TrackLength="4:04",
                TrackTitle="Guilt Trip"
            },
new TrackDB()
            {
                ID="88",
                AlbumID="6",
                TrackNumberInAlbum=9,
                TrackLength="2:58",
                TrackTitle="Send It UpSend It Up"
            },
new TrackDB()
            {
                ID="89",
                AlbumID="6",
                TrackNumberInAlbum=10,
                TrackLength="3:49",
                TrackTitle="Bound 2"
            },
new TrackDB()
            {
                ID="90",
                AlbumID="7",
                TrackNumberInAlbum=1,
                TrackLength="5:20",
                TrackTitle="Ultralight Beam"
            },
new TrackDB()
            {
                ID="91",
                AlbumID="7",
                TrackNumberInAlbum=2,
                TrackLength="2:15",
                TrackTitle="Father Stretch My Hands, Pt. 1"
            },
new TrackDB()
            {
                ID="92",
                AlbumID="7",
                TrackNumberInAlbum=3,
                TrackLength="2:09",
                TrackTitle="Pt. 2"
            },
new TrackDB()
            {
                ID="93",
                AlbumID="7",
                TrackNumberInAlbum=4,
                TrackLength="3:14",
                TrackTitle="Famous"
            },
new TrackDB()
            {
                ID="94",
                AlbumID="7",
                TrackNumberInAlbum=5,
                TrackLength="2:35",
                TrackTitle="Feedback"
            },
new TrackDB()
            {
                ID="95",
                AlbumID="7",
                TrackNumberInAlbum=6,
                TrackLength="2:11",
                TrackTitle="Low Lights"
            },
new TrackDB()
            {
                ID="96",
                AlbumID="7",
                TrackNumberInAlbum=7,
                TrackLength="3:19",
                TrackTitle="Highlights"
            },
new TrackDB()
            {
                ID="97",
                AlbumID="7",
                TrackNumberInAlbum=8,
                TrackLength="2:02",
                TrackTitle="Freestyle 4"
            },
new TrackDB()
            {
                ID="98",
                AlbumID="7",
                TrackNumberInAlbum=9,
                TrackLength="0:44",
                TrackTitle="I Love Kanye"
            },
new TrackDB()
            {
                ID="99",
                AlbumID="7",
                TrackNumberInAlbum=10,
                TrackLength="3:01",
                TrackTitle="Waves"
            },
new TrackDB()
            {
                ID="100",
                AlbumID="7",
                TrackNumberInAlbum=11,
                TrackLength="3:56",
                TrackTitle="FML"
            },
new TrackDB()
            {
                ID="101",
                AlbumID="7",
                TrackNumberInAlbum=12,
                TrackLength="4:11",
                TrackTitle="Real Friends"
            },
new TrackDB()
            {
                ID="102",
                AlbumID="7",
                TrackNumberInAlbum=13,
                TrackLength="3:59",
                TrackTitle="Wolves"
            },
new TrackDB()
            {
                ID="103",
                AlbumID="7",
                TrackNumberInAlbum=14,
                TrackLength="0:56",
                TrackTitle="Siiiiiiiiilver Surffffeeeeer Intermission"
            },
new TrackDB()
            {
                ID="104",
                AlbumID="7",
                TrackNumberInAlbum=15,
                TrackLength="5:25",
                TrackTitle="30 Hours"
            },
new TrackDB()
            {
                ID="105",
                AlbumID="7",
                TrackNumberInAlbum=16,
                TrackLength="6:14",
                TrackTitle="No More Parties in LA"
            },
new TrackDB()
            {
                ID="106",
                AlbumID="7",
                TrackNumberInAlbum=17,
                TrackLength="3:19",
                TrackTitle="Facts (Charlie Heat Version)"
            },
new TrackDB()
            {
                ID="107",
                AlbumID="7",
                TrackNumberInAlbum=18,
                TrackLength="3:13",
                TrackTitle="Fade"
            },
new TrackDB()
            {
                ID="108",
                AlbumID="8",
                TrackNumberInAlbum=1,
                TrackLength="4:34",
                TrackTitle="I Thought About Killing You"
            },
new TrackDB()
            {
                ID="109",
                AlbumID="8",
                TrackNumberInAlbum=2,
                TrackLength="3:08",
                TrackTitle="Yikes"
            },
new TrackDB()
            {
                ID="110",
                AlbumID="8",
                TrackNumberInAlbum=3,
                TrackLength="2:25",
                TrackTitle="All Mine"
            },
new TrackDB()
            {
                ID="111",
                AlbumID="8",
                TrackNumberInAlbum=4,
                TrackLength="3:25",
                TrackTitle="Wouldnt Leave"
            },
new TrackDB()
            {
                ID="112",
                AlbumID="8",
                TrackNumberInAlbum=5,
                TrackLength="2:03",
                TrackTitle="No Mistakes"
            },
new TrackDB()
            {
                ID="113",
                AlbumID="8",
                TrackNumberInAlbum=6,
                TrackLength="4:31",
                TrackTitle="Ghost Town"
            },
new TrackDB()
            {
                ID="114",
                AlbumID="8",
                TrackNumberInAlbum=7,
                TrackLength="3:35",
                TrackTitle="Violent Crimes"
            },
new TrackDB()
            {
                ID="115",
                AlbumID="9",
                TrackNumberInAlbum=1,
                TrackLength="1:52",
                TrackTitle="Every Hour"
            },
new TrackDB()
            {
                ID="116",
                AlbumID="9",
                TrackNumberInAlbum=2,
                TrackLength="2:45",
                TrackTitle="Selah"
            },
new TrackDB()
            {
                ID="117",
                AlbumID="9",
                TrackNumberInAlbum=3,
                TrackLength="1:45",
                TrackTitle="Follow God"
            },
new TrackDB()
            {
                ID="118",
                AlbumID="9",
                TrackNumberInAlbum=4,
                TrackLength="2:32",
                TrackTitle="Closed on Sunday"
            },
new TrackDB()
            {
                ID="119",
                AlbumID="9",
                TrackNumberInAlbum=5,
                TrackLength="2:16",
                TrackTitle="On God"
            },
new TrackDB()
            {
                ID="120",
                AlbumID="9",
                TrackNumberInAlbum=6,
                TrackLength="1:57",
                TrackTitle="Everything We Need"
            },
new TrackDB()
            {
                ID="121",
                AlbumID="9",
                TrackNumberInAlbum=7,
                TrackLength="2:48",
                TrackTitle="Water"
            },
new TrackDB()
            {
                ID="122",
                AlbumID="9",
                TrackNumberInAlbum=8,
                TrackLength="3:23",
                TrackTitle="God Is"
            },
new TrackDB()
            {
                ID="123",
                AlbumID="9",
                TrackNumberInAlbum=9,
                TrackLength="3:23",
                TrackTitle="Hands On"
            },
new TrackDB()
            {
                ID="124",
                AlbumID="9",
                TrackNumberInAlbum=10,
                TrackLength="3:34",
                TrackTitle="Use This Gospel"
            },
new TrackDB()
            {
                ID="125",
                AlbumID="9",
                TrackNumberInAlbum=11,
                TrackLength="0:49",
                TrackTitle="Jesus Is Lord"
            },
new TrackDB()
            {
                ID="126",
                AlbumID="10",
                TrackNumberInAlbum=1,
                TrackLength="0:52",
                TrackTitle="Donda Chant"
            },
new TrackDB()
            {
                ID="127",
                AlbumID="10",
                TrackNumberInAlbum=2,
                TrackLength="4:57",
                TrackTitle="Jail"
            },
new TrackDB()
            {
                ID="128",
                AlbumID="10",
                TrackNumberInAlbum=3,
                TrackLength="5:33",
                TrackTitle="God Breathed"
            },
new TrackDB()
            {
                ID="129",
                AlbumID="10",
                TrackNumberInAlbum=4,
                TrackLength="5:39",
                TrackTitle="Off the Grid"
            },
new TrackDB()
            {
                ID="130",
                AlbumID="10",
                TrackNumberInAlbum=5,
                TrackLength="4:03",
                TrackTitle="Hurricane"
            },
new TrackDB()
            {
                ID="131",
                AlbumID="10",
                TrackNumberInAlbum=6,
                TrackLength="3:46",
                TrackTitle="Praise God"
            },
new TrackDB()
            {
                ID="132",
                AlbumID="10",
                TrackNumberInAlbum=7,
                TrackLength="3:15",
                TrackTitle="Jonah"
            },
new TrackDB()
            {
                ID="133",
                AlbumID="10",
                TrackNumberInAlbum=8,
                TrackLength="3:24",
                TrackTitle="OK OK"
            },
new TrackDB()
            {
                ID="134",
                AlbumID="10",
                TrackNumberInAlbum=9,
                TrackLength="2:27",
                TrackTitle="Junya"
            },
new TrackDB()
            {
                ID="135",
                AlbumID="10",
                TrackNumberInAlbum=10,
                TrackLength="4:02",
                TrackTitle="Believe What I Say"
            },
new TrackDB()
            {
                ID="136",
                AlbumID="10",
                TrackNumberInAlbum=11,
                TrackLength="3:17",
                TrackTitle="24"
            },
new TrackDB()
            {
                ID="137",
                AlbumID="10",
                TrackNumberInAlbum=12,
                TrackLength="3:18",
                TrackTitle="Remote Control"
            },
new TrackDB()
            {
                ID="138",
                AlbumID="10",
                TrackNumberInAlbum=13,
                TrackLength="2:36",
                TrackTitle="Moon"
            },
new TrackDB()
            {
                ID="139",
                AlbumID="10",
                TrackNumberInAlbum=14,
                TrackLength="2:25",
                TrackTitle="Heaven and Hell"
            },
new TrackDB()
            {
                ID="140",
                AlbumID="10",
                TrackNumberInAlbum=15,
                TrackLength="2:08",
                TrackTitle="Donda"
            },
new TrackDB()
            {
                ID="141",
                AlbumID="10",
                TrackNumberInAlbum=16,
                TrackLength="3:41",
                TrackTitle="Keep My Spirit Alive"
            },
new TrackDB()
            {
                ID="142",
                AlbumID="10",
                TrackNumberInAlbum=17,
                TrackLength="8:58",
                TrackTitle="Jesus Lord"
            },
new TrackDB()
            {
                ID="143",
                AlbumID="10",
                TrackNumberInAlbum=18,
                TrackLength="3:03",
                TrackTitle="New Again"
            },
new TrackDB()
            {
                ID="144",
                AlbumID="10",
                TrackNumberInAlbum=19,
                TrackLength="1:44",
                TrackTitle="Tell the Vision"
            },
new TrackDB()
            {
                ID="145",
                AlbumID="10",
                TrackNumberInAlbum=20,
                TrackLength="2:42",
                TrackTitle="Lord I Need You"
            },
new TrackDB()
            {
                ID="146",
                AlbumID="10",
                TrackNumberInAlbum=21,
                TrackLength="5:58",
                TrackTitle="Pure Souls"
            },
new TrackDB()
            {
                ID="147",
                AlbumID="10",
                TrackNumberInAlbum=22,
                TrackLength="5:10",
                TrackTitle="Come to Life"
            },
new TrackDB()
            {
                ID="148",
                AlbumID="10",
                TrackNumberInAlbum=23,
                TrackLength="2:57",
                TrackTitle="No Child Left Behind"
            },
new TrackDB()
            {
                ID="149",
                AlbumID="10",
                TrackNumberInAlbum=24,
                TrackLength="4:57",
                TrackTitle="Jail Pt 2"
            },
new TrackDB()
            {
                ID="150",
                AlbumID="10",
                TrackNumberInAlbum=25,
                TrackLength="3:24",
                TrackTitle="OK OK Pt 2"
            },
new TrackDB()
            {
                ID="151",
                AlbumID="10",
                TrackNumberInAlbum=26,
                TrackLength="3:02",
                TrackTitle="Junya Pt 2"
            },
new TrackDB()
            {
                ID="152",
                AlbumID="10",
                TrackNumberInAlbum=27,
                TrackLength="11:30",
                TrackTitle="Jesus Lord Pt 2"
            },
new TrackDB()
            {
                ID="153",
                AlbumID="11",
                TrackNumberInAlbum=1,
                TrackLength="2:37",
                TrackTitle="1539 N. Calvert"
            },
new TrackDB()
            {
                ID="154",
                AlbumID="11",
                TrackNumberInAlbum=2,
                TrackLength="2:31",
                TrackTitle="Real Nega"
            },
new TrackDB()
            {
                ID="155",
                AlbumID="11",
                TrackNumberInAlbum=3,
                TrackLength="3:18",
                TrackTitle="Thug Tears"
            },
new TrackDB()
            {
                ID="156",
                AlbumID="11",
                TrackNumberInAlbum=4,
                TrackLength="1:26",
                TrackTitle="Dayum"
            },
new TrackDB()
            {
                ID="157",
                AlbumID="11",
                TrackNumberInAlbum=5,
                TrackLength="2:34",
                TrackTitle="Baby I'm Bleeding"
            },
new TrackDB()
            {
                ID="158",
                AlbumID="11",
                TrackNumberInAlbum=6,
                TrackLength="1:34",
                TrackTitle="My Thoughts on Neogaf Dying"
            },
new TrackDB()
            {
                ID="159",
                AlbumID="11",
                TrackNumberInAlbum=7,
                TrackLength="3:08",
                TrackTitle="Rock N Roll Is Dead"
            },
new TrackDB()
            {
                ID="160",
                AlbumID="11",
                TrackNumberInAlbum=8,
                TrackLength="3:15",
                TrackTitle="DD Form 214"
            },
new TrackDB()
            {
                ID="161",
                AlbumID="11",
                TrackNumberInAlbum=9,
                TrackLength="2:41",
                TrackTitle="Germs"
            },
new TrackDB()
            {
                ID="162",
                AlbumID="11",
                TrackNumberInAlbum=10,
                TrackLength="1:20",
                TrackTitle="Libtard Anthem"
            },
new TrackDB()
            {
                ID="163",
                AlbumID="11",
                TrackNumberInAlbum=11,
                TrackLength="3:00",
                TrackTitle="Panic Emoji"
            },
new TrackDB()
            {
                ID="164",
                AlbumID="11",
                TrackNumberInAlbum=12,
                TrackLength="1:23",
                TrackTitle="DJ Snitch Interlude"
            },
new TrackDB()
            {
                ID="165",
                AlbumID="11",
                TrackNumberInAlbum=13,
                TrackLength="2:04",
                TrackTitle="Whole Foods"
            },
new TrackDB()
            {
                ID="166",
                AlbumID="11",
                TrackNumberInAlbum=14,
                TrackLength="1:57",
                TrackTitle="Macaulay Culkin"
            },
new TrackDB()
            {
                ID="167",
                AlbumID="11",
                TrackNumberInAlbum=15,
                TrackLength="3:33",
                TrackTitle="Williamsburg"
            },
new TrackDB()
            {
                ID="168",
                AlbumID="11",
                TrackNumberInAlbum=16,
                TrackLength="1:26",
                TrackTitle="I Cannot Wait Until Morrissey Dies"
            },
new TrackDB()
            {
                ID="169",
                AlbumID="11",
                TrackNumberInAlbum=17,
                TrackLength="4:43",
                TrackTitle="Rainbow Six"
            },
new TrackDB()
            {
                ID="170",
                AlbumID="11",
                TrackNumberInAlbum=18,
                TrackLength="2:28",
                TrackTitle="1488"
            },
new TrackDB()
            {
                ID="171",
                AlbumID="11",
                TrackNumberInAlbum=19,
                TrackLength="2:15",
                TrackTitle="Curb Stomp"
            }

        };
        public static readonly IReadOnlyList<Review> Reviews = new List<Review> { 
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="1",
                userID=users[1].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="1",
                userID=users[0].Id,
                rating=3,
                reviewText="Mid"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="2",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="3",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="4",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="5",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="6",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="7",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="8",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="9",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="10",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
            new Review()
            {
                ID=Guid.NewGuid().ToString(),
                albumID="11",
                userID=users[0].Id,
                rating=5,
                reviewText="Good"
            },
        };
        public static readonly IReadOnlyList<Album> Albums = new List<Album> {
            new Album()
            {
                ID="1",
                albumName="The College Dropout",
                releaseDate=new DateTime(2004,02,10),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="2",
                albumName="Late Registration",
                releaseDate=new DateTime(2005,08,30),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="3",
                albumName="Graduation",
                releaseDate=new DateTime(2007,09,11),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="4",
                albumName="808s & Heartbreak",
                releaseDate=new DateTime(2008,11,24),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="5",
                albumName="My Beautiful Dark Twisted Fantasy",
                releaseDate=new DateTime(2010,11,22),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="6",
                albumName="Yeezus",
                releaseDate=new DateTime(2013,06,11),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="7",
                albumName="The Life of Pablo",
                releaseDate=new DateTime(2016,02,14),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="8",
                albumName="ye",
                releaseDate=new DateTime(2018,06,01),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="9",
                albumName="JESUS IS KING",
                releaseDate=new DateTime(2019,10,25),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="10",
                albumName="Donda",
                releaseDate=new DateTime(2021,08,29),
                artistName="Kanye West"
            },
            new Album()
            {
                ID="11",
                albumName="Veteran",
                releaseDate=new DateTime(2018,01,18),
                artistName="JPEGMAFIA"
            }
        };
    }
}
