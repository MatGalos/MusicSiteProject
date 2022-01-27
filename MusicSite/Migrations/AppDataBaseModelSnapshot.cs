﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicSite.Models;

namespace MusicSite.Migrations
{
    [DbContext(typeof(AppDataBase))]
    partial class AppDataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "hdfsgkjhaskdhadsfk",
                            ConcurrencyStamp = "e3494634-fd5e-4e2b-a0a2-2219458f4e5e",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "asdapsoid[pias",
                            ConcurrencyStamp = "65b2de13-4762-49c0-9642-1f500be05eb6",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "asdapsoid[pias"
                        },
                        new
                        {
                            UserId = "113dsad-adsasasd",
                            RoleId = "hdfsgkjhaskdhadsfk"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MusicSite.Models.Album", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("albumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("artistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("releaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            ID = "1",
                            albumName = "The College Dropout",
                            artistName = "Kanye West",
                            releaseDate = new DateTime(2004, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MusicSite.Models.Review", b =>
                {
                    b.Property<string>("albumID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<byte>("rating")
                        .HasColumnType("tinyint");

                    b.Property<string>("reviewText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("albumID", "userID");

                    b.HasIndex("userID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            albumID = "1",
                            userID = "1",
                            ID = "1",
                            rating = (byte)5,
                            reviewText = "Good"
                        });
                });

            modelBuilder.Entity("MusicSite.Models.Track.TrackDB", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AlbumID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrackLength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackNumberInAlbum")
                        .HasColumnType("int");

                    b.Property<string>("TrackTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            ID = "1",
                            AlbumID = "1",
                            TrackLength = "0:19",
                            TrackNumberInAlbum = 1,
                            TrackTitle = "Intro"
                        });
                });

            modelBuilder.Entity("MusicSite.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("AccountCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            AccountCreationDate = new DateTime(2022, 1, 27, 19, 42, 53, 14, DateTimeKind.Local).AddTicks(6575),
                            ConcurrencyStamp = "c1c03da2-dfaa-49b8-8db8-93d90fd22959",
                            CreationDate = new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mateuszgalos@gmail.com",
                            EmailConfirmed = false,
                            LastName = "Galos",
                            LockoutEnabled = false,
                            Name = "Mateusz",
                            PasswordHash = "AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "84518c1a-f194-49ec-a781-d92698e866b6",
                            TwoFactorEnabled = false,
                            UserName = "MAgick90909"
                        },
                        new
                        {
                            Id = "113dsad-adsasasd",
                            AccessFailedCount = 0,
                            AccountCreationDate = new DateTime(2022, 1, 27, 19, 42, 53, 17, DateTimeKind.Local).AddTicks(5046),
                            ConcurrencyStamp = "21c49434-aa54-4815-bceb-ab4fbaa50e09",
                            CreationDate = new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Admin@gmail.com",
                            EmailConfirmed = false,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENLAxThpZFLG18QfD7iVm7rPvN4PwFqICoLU43hI0P0cTBJvk1spWXu/5MsasFGvyA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4c2e13ca-c88d-4ec2-b20f-4c01800db9db",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MusicSite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MusicSite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicSite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MusicSite.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicSite.Models.Review", b =>
                {
                    b.HasOne("MusicSite.Models.Album", "album")
                        .WithMany("albumReviews")
                        .HasForeignKey("albumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicSite.Models.User", "author")
                        .WithMany("UserReviews")
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("album");

                    b.Navigation("author");
                });

            modelBuilder.Entity("MusicSite.Models.Track.TrackDB", b =>
                {
                    b.HasOne("MusicSite.Models.Album", "Album")
                        .WithMany("albumTrackList")
                        .HasForeignKey("AlbumID");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MusicSite.Models.Album", b =>
                {
                    b.Navigation("albumReviews");

                    b.Navigation("albumTrackList");
                });

            modelBuilder.Entity("MusicSite.Models.User", b =>
                {
                    b.Navigation("UserReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
