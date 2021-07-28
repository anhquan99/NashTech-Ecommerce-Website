﻿// <auto-generated />
using System;
using Ecomerece_Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecomerece_Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210727185309_delete-on-cascade-1")]
    partial class deleteoncascade1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecomerece_Web.Data.Brand", b =>
                {
                    b.Property<string>("brandNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("brandNameID");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Category", b =>
                {
                    b.Property<string>("categoryNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("categoryNameID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Color", b =>
                {
                    b.Property<string>("colorNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("colorNameID");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Image", b =>
                {
                    b.Property<string>("imageNameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("productNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("imageNameID");

                    b.HasIndex("productNameID");

                    b.ToTable("images");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Product", b =>
                {
                    b.Property<string>("productNameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("brandNameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("categoryNameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("colorNameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("colorWay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coverImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<double>("rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("releaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("silhouetteNameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeNameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("upperMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("usedPrice")
                        .HasColumnType("float");

                    b.Property<int>("view")
                        .HasColumnType("int");

                    b.Property<string>("wallpaper")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productNameID");

                    b.HasIndex("brandNameID");

                    b.HasIndex("categoryNameID");

                    b.HasIndex("colorNameID");

                    b.HasIndex("silhouetteNameID");

                    b.HasIndex("typeNameID");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Silhouette", b =>
                {
                    b.Property<string>("silhouetteNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("silhouetteNameID");

                    b.ToTable("silhouettes");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Type", b =>
                {
                    b.Property<string>("typeNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("typeNameID");

                    b.ToTable("types");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.Property<string>("userWantProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("wantedProductproductNameID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("userWantProductId", "wantedProductproductNameID");

                    b.HasIndex("wantedProductproductNameID");

                    b.ToTable("ProductUser");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Image", b =>
                {
                    b.HasOne("Ecomerece_Web.Data.Product", null)
                        .WithMany("images")
                        .HasForeignKey("productNameID");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Product", b =>
                {
                    b.HasOne("Ecomerece_Web.Data.Brand", "brand")
                        .WithMany("products")
                        .HasForeignKey("brandNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomerece_Web.Data.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomerece_Web.Data.Color", "color")
                        .WithMany("products")
                        .HasForeignKey("colorNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomerece_Web.Data.Silhouette", "silhouette")
                        .WithMany("products")
                        .HasForeignKey("silhouetteNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomerece_Web.Data.Type", "type")
                        .WithMany("products")
                        .HasForeignKey("typeNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");

                    b.Navigation("category");

                    b.Navigation("color");

                    b.Navigation("silhouette");

                    b.Navigation("type");
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
                    b.HasOne("Ecomerece_Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ecomerece_Web.Data.User", null)
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

                    b.HasOne("Ecomerece_Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ecomerece_Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.HasOne("Ecomerece_Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("userWantProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomerece_Web.Data.Product", null)
                        .WithMany()
                        .HasForeignKey("wantedProductproductNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Brand", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Color", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Product", b =>
                {
                    b.Navigation("images");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Silhouette", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Ecomerece_Web.Data.Type", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}