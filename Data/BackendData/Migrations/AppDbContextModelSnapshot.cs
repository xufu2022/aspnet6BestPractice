﻿// <auto-generated />
using BackendData.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("BackendData.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PluralsightUrl")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("TwitterAlias")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Steve Smith",
                            PluralsightUrl = "https://www.pluralsight.com/authors/steve-smith",
                            TwitterAlias = "ardalis"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Julie Lerman",
                            PluralsightUrl = "https://www.pluralsight.com/authors/julie-lerman",
                            TwitterAlias = "julialerman"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
