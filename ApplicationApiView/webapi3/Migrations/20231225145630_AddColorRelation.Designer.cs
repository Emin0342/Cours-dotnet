﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using newWebAPI.Models;

#nullable disable

namespace newWebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231225145630_AddColorRelation")]
    partial class AddColorRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("newWebAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

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

                    b.Property<int?>("colorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("colorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Christian Nagel",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2016, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 6 and .NET Core 1.0",
                            colorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Author = "Christian Nagel",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2018, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 7 and .NET Core 2.0",
                            colorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Author = "Christian Nagel",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 8 and .NET Core 3.0",
                            colorId = 3
                        },
                        new
                        {
                            Id = 4,
                            Author = "Christian Nagel",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 9 and .NET 5",
                            colorId = 1
                        },
                        new
                        {
                            Id = 5,
                            Author = "Perkins, Reid, and Hammer",
                            Description = "The perfect guide to Visual C#",
                            Genre = "Software",
                            Price = 45m,
                            PublishDate = new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Beginning Visual C# 2019",
                            colorId = 2
                        },
                        new
                        {
                            Id = 6,
                            Author = "Andrew Troelsen",
                            Description = "The ultimate C# resource",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pro C# 7",
                            colorId = 3
                        });
                });

            modelBuilder.Entity("newWebAPI.Models.Color", b =>
                {
                    b.Property<int>("colorId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("colorId");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            colorId = 1,
                            color = "red"
                        },
                        new
                        {
                            colorId = 2,
                            color = "blue"
                        },
                        new
                        {
                            colorId = 3,
                            color = "green"
                        });
                });

            modelBuilder.Entity("newWebAPI.Models.Book", b =>
                {
                    b.HasOne("newWebAPI.Models.Color", "Color")
                        .WithMany("Books")
                        .HasForeignKey("colorId");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("newWebAPI.Models.Color", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
