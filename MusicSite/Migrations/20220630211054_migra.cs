﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicSite.Migrations
{
    public partial class migra : Migration
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
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    albumID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    reviewText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
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
                    { "hdfsgkjhaskdhadsfk", "6a9576a5-ea96-408d-a155-d3ff7af4928f", "Admin", null },
                    { "asdapsoid[pias", "21b354da-bc75-45af-87e3-3fe4f2838d73", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountCreationDate", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2", 0, new DateTime(2022, 6, 30, 23, 10, 53, 358, DateTimeKind.Local).AddTicks(5269), "966ac234-b8a5-40f9-b33c-f9d04bdab964", new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mateuszgalos@gmail.com", false, "Galos", false, null, "Mateusz", null, "MAGICK90909", "AQAAAAEAACcQAAAAEDlJWPiUH6IbruRxBjc/g4EnjjVYpJo/X+ibGtH8j2FoogbAopUJvHzSC1G2+1aGZg==", null, false, "3dd977be-b010-441b-9b54-1f08d2c3adab", false, "MAgick90909" },
                    { "5f0ac504-5cbc-4ca3-9bfa-52efe61d211b", 0, new DateTime(2022, 6, 30, 23, 10, 53, 361, DateTimeKind.Local).AddTicks(5217), "2c54746d-f6d8-47dc-aa8b-b15a82fc4b6e", new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@gmail.com", false, "Stefanowy", false, null, "Stefan", null, "USER2", "AQAAAAEAACcQAAAAEDlJWPiUH6IbruRxBjc/g4EnjjVYpJo/X+ibGtH8j2FoogbAopUJvHzSC1G2+1aGZg==", null, false, "b0412aae-86f5-4c52-85d9-80e38b48d02b", false, "User2" },
                    { "3895bab7-e7f2-464a-b9e4-9c5b331846e6", 0, new DateTime(2022, 6, 30, 23, 10, 53, 361, DateTimeKind.Local).AddTicks(5297), "23f4afd5-08bb-4ce2-a0a6-fd08d05bd37f", new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@gmail.com", false, "Admin", false, null, "Admin", null, "ADMIN", "AQAAAAEAACcQAAAAEDlJWPiUH6IbruRxBjc/g4EnjjVYpJo/X+ibGtH8j2FoogbAopUJvHzSC1G2+1aGZg==", null, false, "38515cc3-fa8b-46b4-aaee-b7cc587f7aa9", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "hdfsgkjhaskdhadsfk", "3895bab7-e7f2-464a-b9e4-9c5b331846e6" },
                    { "asdapsoid[pias", "5f0ac504-5cbc-4ca3-9bfa-52efe61d211b" },
                    { "asdapsoid[pias", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "albumID", "rating", "reviewText", "userID" },
                values: new object[,]
                {
                    { "372f275d-710c-4449-8fb4-200e1175e8d8", "1", 3, "Mid", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "c2a1a57f-4603-4e0d-9e34-b57a35da1657", "2", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "8afeafae-b29b-435b-90a1-480bd48b797d", "3", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "9a523f81-53d1-4878-95f2-d20dd93ad036", "4", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "2888ed4b-3b24-48ef-aed9-d9101889a9c8", "5", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "af05cc60-9330-469a-9b72-d0b4f6c0e067", "1", 5, "Good", "5f0ac504-5cbc-4ca3-9bfa-52efe61d211b" },
                    { "d5323282-2ac6-4548-8d6c-7b4bde1b670f", "7", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "82e34e10-c52e-4f8b-8d92-fed22c051870", "8", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "7d6cc5f8-29bc-43a6-99d5-85c28f3d9501", "9", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "55d607a5-4ecd-46f9-a66f-be8a02c5068d", "10", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "793dab05-b3ad-4371-b5c8-46919b14b622", "11", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" },
                    { "4958bacf-baf2-4871-a143-a51e06d0a602", "6", 5, "Good", "702247f8-9a4d-4c5f-9a0e-c2309eafbbc2" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "116", "9", "2:45", 2, "Selah" },
                    { "117", "9", "1:45", 3, "Follow God" },
                    { "118", "9", "2:32", 4, "Closed on Sunday" },
                    { "119", "9", "2:16", 5, "On God" },
                    { "120", "9", "1:57", 6, "Everything We Need" },
                    { "121", "9", "2:48", 7, "Water" },
                    { "122", "9", "3:23", 8, "God Is" },
                    { "125", "9", "0:49", 11, "Jesus Is Lord" },
                    { "124", "9", "3:34", 10, "Use This Gospel" },
                    { "115", "9", "1:52", 1, "Every Hour" },
                    { "126", "10", "0:52", 1, "Donda Chant" },
                    { "127", "10", "4:57", 2, "Jail" },
                    { "128", "10", "5:33", 3, "God Breathed" },
                    { "129", "10", "5:39", 4, "Off the Grid" },
                    { "130", "10", "4:03", 5, "Hurricane" },
                    { "123", "9", "3:23", 9, "Hands On" },
                    { "114", "8", "3:35", 7, "Violent Crimes" },
                    { "111", "8", "3:25", 4, "Wouldnt Leave" },
                    { "112", "8", "2:03", 5, "No Mistakes" },
                    { "95", "7", "2:11", 6, "Low Lights" },
                    { "96", "7", "3:19", 7, "Highlights" },
                    { "97", "7", "2:02", 8, "Freestyle 4" },
                    { "98", "7", "0:44", 9, "I Love Kanye" },
                    { "99", "7", "3:01", 10, "Waves" },
                    { "100", "7", "3:56", 11, "FML" },
                    { "101", "7", "4:11", 12, "Real Friends" },
                    { "102", "7", "3:59", 13, "Wolves" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "103", "7", "0:56", 14, "Siiiiiiiiilver Surffffeeeeer Intermission" },
                    { "104", "7", "5:25", 15, "30 Hours" },
                    { "105", "7", "6:14", 16, "No More Parties in LA" },
                    { "106", "7", "3:19", 17, "Facts (Charlie Heat Version)" },
                    { "107", "7", "3:13", 18, "Fade" },
                    { "108", "8", "4:34", 1, "I Thought About Killing You" },
                    { "109", "8", "3:08", 2, "Yikes" },
                    { "110", "8", "2:25", 3, "All Mine" },
                    { "131", "10", "3:46", 6, "Praise God" },
                    { "113", "8", "4:31", 6, "Ghost Town" },
                    { "132", "10", "3:15", 7, "Jonah" },
                    { "135", "10", "4:02", 10, "Believe What I Say" },
                    { "134", "10", "2:27", 9, "Junya" },
                    { "156", "11", "1:26", 4, "Dayum" },
                    { "157", "11", "2:34", 5, "Baby I'm Bleeding" },
                    { "158", "11", "1:34", 6, "My Thoughts on Neogaf Dying" },
                    { "159", "11", "3:08", 7, "Rock N Roll Is Dead" },
                    { "160", "11", "3:15", 8, "DD Form 214" },
                    { "161", "11", "2:41", 9, "Germs" },
                    { "162", "11", "1:20", 10, "Libtard Anthem" },
                    { "155", "11", "3:18", 3, "Thug Tears" },
                    { "163", "11", "3:00", 11, "Panic Emoji" },
                    { "165", "11", "2:04", 13, "Whole Foods" },
                    { "166", "11", "1:57", 14, "Macaulay Culkin" },
                    { "167", "11", "3:33", 15, "Williamsburg" },
                    { "168", "11", "1:26", 16, "I Cannot Wait Until Morrissey Dies" },
                    { "169", "11", "4:43", 17, "Rainbow Six" },
                    { "170", "11", "2:28", 18, "1488" },
                    { "171", "11", "2:15", 19, "Curb Stomp" },
                    { "164", "11", "1:23", 12, "DJ Snitch Interlude" },
                    { "133", "10", "3:24", 8, "OK OK" },
                    { "154", "11", "2:31", 2, "Real Nega" },
                    { "152", "10", "11:30", 27, "Jesus Lord Pt 2" },
                    { "136", "10", "3:17", 11, "24" },
                    { "137", "10", "3:18", 12, "Remote Control" },
                    { "138", "10", "2:36", 13, "Moon" },
                    { "94", "7", "2:35", 5, "Feedback" },
                    { "140", "10", "2:08", 15, "Donda" },
                    { "141", "10", "3:41", 16, "Keep My Spirit Alive" },
                    { "142", "10", "8:58", 17, "Jesus Lord" },
                    { "153", "11", "2:37", 1, "1539 N. Calvert" },
                    { "143", "10", "3:03", 18, "New Again" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "145", "10", "2:42", 20, "Lord I Need You" },
                    { "146", "10", "5:58", 21, "Pure Souls" },
                    { "147", "10", "5:10", 22, "Come to Life" },
                    { "148", "10", "2:57", 23, "No Child Left Behind" },
                    { "149", "10", "4:57", 24, "Jail Pt 2" },
                    { "150", "10", "3:24", 25, "OK OK Pt 2" },
                    { "151", "10", "3:02", 26, "Junya Pt 2" },
                    { "144", "10", "1:44", 19, "Tell the Vision" },
                    { "139", "10", "2:25", 14, "Heaven and Hell" },
                    { "93", "7", "3:14", 4, "Famous" },
                    { "91", "7", "2:15", 2, "Father Stretch My Hands, Pt. 1" },
                    { "25", "2", "3:27", 4, "Gold Digger" },
                    { "26", "2", "0:33", 5, "Skit #1" },
                    { "27", "2", "4:32", 6, "Drive Slow" },
                    { "28", "2", "1:43", 7, "My Way Home" },
                    { "29", "2", "4:31", 8, "Crack Music" },
                    { "30", "2", "4:05", 9, "Roses" },
                    { "31", "2", "3:19", 10, "Bring Me Down" },
                    { "32", "2", "4:27", 11, "Addiction" },
                    { "33", "2", "0:31", 12, "Skit #2" },
                    { "34", "2", "3:53", 13, "Diamonds From Sierra Leone (Remix)" },
                    { "35", "2", "7:28", 14, "We Major" },
                    { "36", "2", "0:24", 15, "Skit #3" },
                    { "37", "2", "5:05", 16, "Hey Mama" },
                    { "38", "2", "3:18", 17, "Celebration" },
                    { "39", "2", "1:19", 18, "Skit #4" },
                    { "40", "2", "5:32", 19, "Gone" },
                    { "41", "2", "3:58", 20, "Diamonds From Sierra Leone [bonus track]" },
                    { "42", "2", "3:50", 21, "Late" },
                    { "43", "3", "3:15", 1, "Good Morning" },
                    { "24", "2", "3:56", 3, "Touch the Sky" },
                    { "44", "3", "2:48", 2, "Champion" },
                    { "23", "2", "3:25", 2, "Heard Em Say" },
                    { "21", "1", "12:40", 21, "Last Call" },
                    { "2", "1", "3:59", 2, "We Don't Care" },
                    { "3", "1", "1:22", 3, "Graduation Day" },
                    { "4", "1", "3:43", 4, "All Falls Down" },
                    { "5", "1", "1:09", 5, "I will Fly Away" },
                    { "6", "1", "5:24", 6, "Spaceship" },
                    { "7", "1", "3:13", 7, "Jesus Walks" },
                    { "8", "1", "5:24", 8, "Never Let Me Down" },
                    { "9", "1", "4:49", 9, "Get Em High" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "10", "1", "0:46", 10, "Workout Plan" },
                    { "11", "1", "5:22", 11, "The New Workout Plan" },
                    { "12", "1", "5:16", 12, "Slow Jamz" },
                    { "13", "1", "4:06", 13, "Breathe In Breathe Out" },
                    { "14", "1", "1:18", 14, "School Spirit Skit 1" },
                    { "15", "1", "3:02", 15, "School Spirit" },
                    { "16", "1", "0:43", 16, "School Spirit Skit 2" },
                    { "17", "1", "0:53", 17, "Lil Jimmy Skit" },
                    { "18", "1", "4:26", 18, "Two Words" },
                    { "19", "1", "3:41", 19, "Through the Wire" },
                    { "20", "1", "4:38", 20, "Family Business" },
                    { "22", "2", "0:41", 1, "Wake Up Mr. West" },
                    { "45", "3", "5:12", 3, "Stronger" },
                    { "46", "3", "4:03", 4, "I Wonder" },
                    { "47", "3", "3:27", 5, "Good Life" },
                    { "72", "5", "6:18", 6, "Monster" },
                    { "73", "5", "6:38", 7, "So Appalled" },
                    { "74", "5", "5:52", 8, "Devil in a New Dress" },
                    { "75", "5", "9:08", 9, "Runaway" },
                    { "76", "5", "5:27", 10, "Hell of a Life" },
                    { "77", "5", "7:49", 11, "Blame Game" },
                    { "78", "5", "4:16", 12, "Lost in the World" },
                    { "79", "5", "1:38", 13, "Who Will Survive in America" },
                    { "80", "6", "2:37", 1, "On Sight" },
                    { "81", "6", "3:08", 2, "Black Skinhead" },
                    { "82", "6", "3:52", 3, "I Am a God" },
                    { "83", "6", "4:16", 4, "New Slaves" },
                    { "84", "6", "5:27", 5, "Hold My Liquor" },
                    { "85", "6", "3:55", 6, "Im in It" },
                    { "86", "6", "6:00", 7, "Blood on the Leaves" },
                    { "87", "6", "4:04", 8, "Guilt Trip" },
                    { "88", "6", "2:58", 9, "Send It UpSend It Up" },
                    { "89", "6", "3:49", 10, "Bound 2" },
                    { "90", "7", "5:20", 1, "Ultralight Beam" },
                    { "71", "5", "4:59", 5, "All of the Lights" },
                    { "70", "5", "1:02", 4, "All of the Lights (Interlude)" },
                    { "69", "5", "4:52", 3, "Power" },
                    { "68", "5", "5:57", 2, "Gorgeous" },
                    { "48", "3", "4:32", 6, "Cant Tell Me Nothing" },
                    { "49", "3", "3:24", 7, "Barry Bonds" },
                    { "50", "3", "3:24", 8, "Drunk and Hot Girls" },
                    { "51", "3", "3:58", 9, "Flashing Lights" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "TrackLength", "TrackNumberInAlbum", "TrackTitle" },
                values: new object[,]
                {
                    { "52", "3", "3:48", 10, "Everything I Am" },
                    { "53", "3", "3:33", 11, "The Glory" },
                    { "54", "3", "3:24", 12, "Homecoming" },
                    { "55", "3", "4:47", 13, "Big Brother" },
                    { "56", "4", "6:18", 1, "Say You Will" },
                    { "92", "7", "2:09", 3, "Pt. 2" },
                    { "57", "4", "4:23", 2, "Welcome to Heartbreak" },
                    { "59", "4", "3:58", 4, "Amazing" },
                    { "60", "4", "4:30", 5, "Love Lockdown" },
                    { "61", "4", "4:38", 6, "Paranoid" },
                    { "62", "4", "4:34", 7, "RoboCop" },
                    { "63", "4", "3:10", 8, "Street Lights" },
                    { "64", "4", "3:59", 9, "Bad News" },
                    { "65", "4", "4:18", 10, "See You in My Nightmares" },
                    { "66", "4", "2:44", 11, "Coldest Winter" },
                    { "67", "5", "4:40", 1, "Dark Fantasy" },
                    { "58", "4", "3:31", 3, "Heartless" },
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
                name: "IX_Reviews_albumID",
                table: "Reviews",
                column: "albumID");

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