﻿// <auto-generated />
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20231218114058_UpdatedCountiesTbale")]
    partial class UpdatedCountiesTbale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelListing.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Azerbaijan",
                            ShortName = "AZ"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Russia",
                            ShortName = "RU"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United Kingdom",
                            ShortName = "UK"
                        },
                        new
                        {
                            Id = 4,
                            Name = "United States Of America",
                            ShortName = "USA"
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Baku",
                            CountryId = 1,
                            Name = "Trump",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Address = "Moscow",
                            CountryId = 2,
                            Name = "Radisson",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "London",
                            CountryId = 3,
                            Name = "The Cumberland",
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            Id = 4,
                            Address = "Las-Vegas",
                            CountryId = 4,
                            Name = "Rio",
                            Rating = 3.6000000000000001
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListing.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
