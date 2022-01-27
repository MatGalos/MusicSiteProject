using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicSite.Migrations
{
    public partial class MusicSiteDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    albumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    releaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    artistName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    TrackNumberInAlbum = table.Column<int>(type: "int", nullable: false),
                    TrackTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    albumID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "NEWID()"),
                    rating = table.Column<byte>(type: "tinyint", nullable: false),
                    reviewText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.albumID, x.userID });
                    table.ForeignKey(
                        name: "FK_Reviews_Albums_albumID",
                        column: x => x.albumID,
                        principalTable: "Albums",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "albumName", "artistName", "releaseDate" },
                values: new object[,]
                {
                    { "1", "The College Dropout", "Kanye West", new DateTime(2004, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2", "Late Registration", "Kanye West", new DateTime(2005, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3", "Graduation", "Kanye West", new DateTime(2007, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4", "808s & Heartbreak", "Kanye West", new DateTime(2008, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5", "My Beautiful Dark Twisted Fantasy", "Kanye West", new DateTime(2010, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6", "Yeezus", "Kanye West", new DateTime(2013, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7", "The Life of Pablo", "Kanye West", new DateTime(2016, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8", "ye", "Kanye West", new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9", "JESUS IS KING", "Kanye West", new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "10", "Donda", "Kanye West", new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "11", "Veteran", "JPEGMAFIA", new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "hdfsgkjhaskdhadsfk", "9cd19dad-62d7-4939-8edd-f41f7c6ef2e2", "Admin", null },
                    { "asdapsoid[pias", "66fa3940-2d10-412a-9f77-45918ce838e5", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountCreationDate", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, new DateTime(2022, 1, 28, 0, 49, 8, 847, DateTimeKind.Local).AddTicks(4352), "55c93e83-32ce-4c25-a26f-6f141b0c1e62", new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mateuszgalos@gmail.com", false, "Galos", false, null, "Mateusz", null, null, "AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==", null, false, "fdd484f0-944e-4db6-a820-e0ceabbebd47", false, "MAgick90909" },
                    { "2", 0, new DateTime(2022, 1, 28, 0, 49, 8, 850, DateTimeKind.Local).AddTicks(3728), "fb390e0c-2985-46a8-ae59-50143d645a4e", new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@gmail.com", false, "Stefanowy", false, null, "Stefan", null, null, "AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==", null, false, "bfa6f3dc-97e3-4ee1-b3f1-9cb835817423", false, "User2" },
                    { "113dsad-adsasasd", 0, new DateTime(2022, 1, 28, 0, 49, 8, 850, DateTimeKind.Local).AddTicks(3816), "1cef9b2d-23c8-4632-9a5a-06e93bdd93e5", new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@gmail.com", false, "Admin", false, null, "Admin", null, "ADMIN", "AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==", null, false, "55fec80d-53f3-4b60-927b-42d3d5d5c045", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "hdfsgkjhaskdhadsfk", "113dsad-adsasasd" },
                    { "asdapsoid[pias", "2" },
                    { "asdapsoid[pias", "1" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "albumID", "userID", "ID", "rating", "reviewText" },
                values: new object[,]
                {
                    { "1", "1", "1", (byte)5, "Good" },
                    { "2", "1", "1", (byte)5, "Good" },
                    { "3", "1", "1", (byte)5, "Good" },
                    { "4", "1", "1", (byte)5, "Good" },
                    { "5", "1", "1", (byte)5, "Good" },
                    { "1", "2", "1", (byte)3, "Mid" },
                    { "7", "1", "1", (byte)5, "Good" },
                    { "8", "1", "1", (byte)5, "Good" },
                    { "9", "1", "1", (byte)5, "Good" },
                    { "10", "1", "1", (byte)5, "Good" },
                    { "11", "1", "1", (byte)5, "Good" },
                    { "6", "1", "1", (byte)5, "Good" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "87", "6", "4:04", 8, "Guilt Trip" },
                    { "88", "6", "2:58", 9, "Send It UpSend It Up" },
                    { "89", "6", "3:49", 10, "Bound 2" },
                    { "90", "7", "5:20", 1, "Ultralight Beam" },
                    { "93", "7", "3:14", 4, "Famous" },
                    { "92", "7", "2:09", 3, "Pt. 2" },
                    { "86", "6", "6:00", 7, "Blood on the Leaves" },
                    { "94", "7", "2:35", 5, "Feedback" },
                    { "95", "7", "2:11", 6, "Low Lights" },
                    { "96", "7", "3:19", 7, "Highlights" },
                    { "91", "7", "2:15", 2, "Father Stretch My Hands, Pt. 1" },
                    { "85", "6", "3:55", 6, "Im in It" },
                    { "82", "6", "3:52", 3, "I Am a God" },
                    { "83", "6", "4:16", 4, "New Slaves" },
                    { "81", "6", "3:08", 2, "Black Skinhead" },
                    { "80", "6", "2:37", 1, "On Sight" },
                    { "79", "5", "1:38", 13, "Who Will Survive in America" },
                    { "78", "5", "4:16", 12, "Lost in the World" },
                    { "77", "5", "7:49", 11, "Blame Game" },
                    { "76", "5", "5:27", 10, "Hell of a Life" },
                    { "75", "5", "9:08", 9, "Runaway" },
                    { "74", "5", "5:52", 8, "Devil in a New Dress" },
                    { "73", "5", "6:38", 7, "So Appalled" },
                    { "72", "5", "6:18", 6, "Monster" },
                    { "84", "6", "5:27", 5, "Hold My Liquor" },
                    { "97", "7", "2:02", 8, "Freestyle 4" },
                    { "100", "7", "3:56", 11, "FML" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "99", "7", "3:01", 10, "Waves" },
                    { "125", "9", "0:49", 11, "Jesus Is Lord" },
                    { "124", "9", "3:34", 10, "Use This Gospel" },
                    { "123", "9", "3:23", 9, "Hands On" },
                    { "122", "9", "3:23", 8, "God Is" },
                    { "121", "9", "2:48", 7, "Water" },
                    { "120", "9", "1:57", 6, "Everything We Need" },
                    { "119", "9", "2:16", 5, "On God" },
                    { "118", "9", "2:32", 4, "Closed on Sunday" },
                    { "117", "9", "1:45", 3, "Follow God" },
                    { "116", "9", "2:45", 2, "Selah" },
                    { "115", "9", "1:52", 1, "Every Hour" },
                    { "114", "8", "3:35", 7, "Violent Crimes" },
                    { "113", "8", "4:31", 6, "Ghost Town" },
                    { "112", "8", "2:03", 5, "No Mistakes" },
                    { "111", "8", "3:25", 4, "Wouldnt Leave" },
                    { "110", "8", "2:25", 3, "All Mine" },
                    { "109", "8", "3:08", 2, "Yikes" },
                    { "108", "8", "4:34", 1, "I Thought About Killing You" },
                    { "107", "7", "3:13", 18, "Fade" },
                    { "106", "7", "3:19", 17, "Facts (Charlie Heat Version)" },
                    { "71", "5", "4:59", 5, "All of the Lights" },
                    { "104", "7", "5:25", 15, "30 Hours" },
                    { "103", "7", "0:56", 14, "Siiiiiiiiilver Surffffeeeeer Intermission" },
                    { "102", "7", "3:59", 13, "Wolves" },
                    { "101", "7", "4:11", 12, "Real Friends" },
                    { "98", "7", "0:44", 9, "I Love Kanye" },
                    { "105", "7", "6:14", 16, "No More Parties in LA" },
                    { "70", "5", "1:02", 4, "All of the Lights (Interlude)" },
                    { "68", "5", "5:57", 2, "Gorgeous" },
                    { "32", "2", "4:27", 11, "Addiction" },
                    { "31", "2", "3:19", 10, "Bring Me Down" },
                    { "30", "2", "4:05", 9, "Roses" },
                    { "29", "2", "4:31", 8, "Crack Music" },
                    { "28", "2", "1:43", 7, "My Way Home" },
                    { "27", "2", "4:32", 6, "Drive Slow" },
                    { "26", "2", "0:33", 5, "Skit #1" },
                    { "25", "2", "3:27", 4, "Gold Digger" },
                    { "24", "2", "3:56", 3, "Touch the Sky" },
                    { "23", "2", "3:25", 2, "Heard Em Say" },
                    { "22", "2", "0:41", 1, "Wake Up Mr. West" },
                    { "21", "1", "12:40", 21, "Last Call" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "20", "1", "4:38", 20, "Family Business" },
                    { "19", "1", "3:41", 19, "Through the Wire" },
                    { "18", "1", "4:26", 18, "Two Words" },
                    { "17", "1", "0:53", 17, "Lil Jimmy Skit" },
                    { "16", "1", "0:43", 16, "School Spirit Skit 2" },
                    { "2", "1", "3:59", 2, "We Don't Care" },
                    { "3", "1", "1:22", 3, "Graduation Day" },
                    { "4", "1", "3:43", 4, "All Falls Down" },
                    { "5", "1", "1:09", 5, "I will Fly Away" },
                    { "6", "1", "5:24", 6, "Spaceship" },
                    { "7", "1", "3:13", 7, "Jesus Walks" },
                    { "33", "2", "0:31", 12, "Skit #2" },
                    { "8", "1", "5:24", 8, "Never Let Me Down" },
                    { "10", "1", "0:46", 10, "Workout Plan" },
                    { "11", "1", "5:22", 11, "The New Workout Plan" },
                    { "12", "1", "5:16", 12, "Slow Jamz" },
                    { "13", "1", "4:06", 13, "Breathe In Breathe Out" },
                    { "14", "1", "1:18", 14, "School Spirit Skit 1" },
                    { "15", "1", "3:02", 15, "School Spirit" },
                    { "9", "1", "4:49", 9, "Get Em High" },
                    { "69", "5", "4:52", 3, "Power" },
                    { "34", "2", "3:53", 13, "Diamonds From Sierra Leone (Remix)" },
                    { "36", "2", "0:24", 15, "Skit #3" },
                    { "67", "5", "4:40", 1, "Dark Fantasy" },
                    { "66", "4", "2:44", 11, "Coldest Winter" },
                    { "65", "4", "4:18", 10, "See You in My Nightmares" },
                    { "64", "4", "3:59", 9, "Bad News" },
                    { "63", "4", "3:10", 8, "Street Lights" },
                    { "62", "4", "4:34", 7, "RoboCop" },
                    { "61", "4", "4:38", 6, "Paranoid" },
                    { "60", "4", "4:30", 5, "Love Lockdown" },
                    { "59", "4", "3:58", 4, "Amazing" },
                    { "58", "4", "3:31", 3, "Heartless" },
                    { "57", "4", "4:23", 2, "Welcome to Heartbreak" },
                    { "56", "4", "6:18", 1, "Say You Will" },
                    { "55", "3", "4:47", 13, "Big Brother" },
                    { "54", "3", "3:24", 12, "Homecoming" },
                    { "53", "3", "3:33", 11, "The Glory" },
                    { "52", "3", "3:48", 10, "Everything I Am" },
                    { "51", "3", "3:58", 9, "Flashing Lights" },
                    { "37", "2", "5:05", 16, "Hey Mama" },
                    { "38", "2", "3:18", 17, "Celebration" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "39", "2", "1:19", 18, "Skit #4" },
                    { "40", "2", "5:32", 19, "Gone" },
                    { "41", "2", "3:58", 20, "Diamonds From Sierra Leone [bonus track]" },
                    { "42", "2", "3:50", 21, "Late" },
                    { "35", "2", "7:28", 14, "We Major" },
                    { "43", "3", "3:15", 1, "Good Morning" },
                    { "45", "3", "5:12", 3, "Stronger" },
                    { "46", "3", "4:03", 4, "I Wonder" },
                    { "47", "3", "3:27", 5, "Good Life" },
                    { "48", "3", "4:32", 6, "Cant Tell Me Nothing" },
                    { "49", "3", "3:24", 7, "Barry Bonds" },
                    { "50", "3", "3:24", 8, "Drunk and Hot Girls" },
                    { "44", "3", "2:48", 2, "Champion" },
                    { "1", "1", "0:19", 1, "Intro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_userID",
                table: "Reviews",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumID",
                table: "Tracks",
                column: "AlbumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
