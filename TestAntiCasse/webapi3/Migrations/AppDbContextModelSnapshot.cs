﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using newWebAPI.Models;

#nullable disable

namespace newWebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("BooksAPI.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BooksAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasMaxLength(200)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishDate")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 0,
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2016, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 6 and .NET Core 1.0"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 0,
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2018, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 7 and .NET Core 2.0"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 0,
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 8 and .NET Core 3.0"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 0,
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 9 and .NET 5"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 0,
                            Description = "The perfect guide to Visual C#",
                            Genre = "Software",
                            Price = 45m,
                            PublishDate = new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Beginning Visual C# 2019"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 0,
                            Description = "The ultimate C# resource",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pro C# 7"
                        });
                });

            modelBuilder.Entity("BooksAPI.Models.Book", b =>
                {
                    b.HasOne("BooksAPI.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BooksAPI.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}