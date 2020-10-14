﻿// <auto-generated />
using System;
using FamilySearchYouthAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilySearchYouthAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201014060559_ForeignKey")]
    partial class ForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("FamilySearchYouthAPI.Models.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("InfoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TextBody")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CardItem");
                });

            modelBuilder.Entity("FamilySearchYouthAPI.Models.Coordinate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Lat")
                        .HasColumnType("REAL");

                    b.Property<double>("Lng")
                        .HasColumnType("REAL");

                    b.Property<int>("RegionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Coordinate");
                });

            modelBuilder.Entity("FamilySearchYouthAPI.Models.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EndYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("FamilySearchYouthAPI.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("FamilySearchYouthAPI.Models.RegionalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClothingId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EconomyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamilyStructureId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamousPeopleId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GeographyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GovernmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HistoricalEventsId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HolidaysandFolkloreId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MigrationsId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MilitaryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MoneyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MusicId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OccupationsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PeriodId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Pioneers")
                        .HasColumnType("TEXT");

                    b.Property<int>("RegionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegionName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReligionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SportsId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TechnologyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Temples")
                        .HasColumnType("TEXT");

                    b.Property<string>("TheChurchStory")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WarsId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WeatherId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WildlifeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClothingId");

                    b.HasIndex("EconomyId");

                    b.HasIndex("FamilyStructureId");

                    b.HasIndex("FamousPeopleId");

                    b.HasIndex("FoodId");

                    b.HasIndex("GeographyId");

                    b.HasIndex("GovernmentId");

                    b.HasIndex("HistoricalEventsId");

                    b.HasIndex("HolidaysandFolkloreId");

                    b.HasIndex("MigrationsId");

                    b.HasIndex("MilitaryId");

                    b.HasIndex("MoneyId");

                    b.HasIndex("MusicId");

                    b.HasIndex("OccupationsId");

                    b.HasIndex("RegionId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("SportsId");

                    b.HasIndex("TechnologyId");

                    b.HasIndex("WarsId");

                    b.HasIndex("WeatherId");

                    b.HasIndex("WildlifeId");

                    b.ToTable("RegionalInformation");
                });

            modelBuilder.Entity("FamilySearchYouthAPI.Models.Coordinate", b =>
                {
                    b.HasOne("FamilySearchYouthAPI.Models.Region", null)
                        .WithMany("Coordinates")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FamilySearchYouthAPI.Models.RegionalInformation", b =>
                {
                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Clothing")
                        .WithMany()
                        .HasForeignKey("ClothingId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Economy")
                        .WithMany()
                        .HasForeignKey("EconomyId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "FamilyStructure")
                        .WithMany()
                        .HasForeignKey("FamilyStructureId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "FamousPeople")
                        .WithMany()
                        .HasForeignKey("FamousPeopleId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Geography")
                        .WithMany()
                        .HasForeignKey("GeographyId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Government")
                        .WithMany()
                        .HasForeignKey("GovernmentId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "HistoricalEvents")
                        .WithMany()
                        .HasForeignKey("HistoricalEventsId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "HolidaysandFolklore")
                        .WithMany()
                        .HasForeignKey("HolidaysandFolkloreId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Migrations")
                        .WithMany()
                        .HasForeignKey("MigrationsId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Military")
                        .WithMany()
                        .HasForeignKey("MilitaryId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Money")
                        .WithMany()
                        .HasForeignKey("MoneyId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Music")
                        .WithMany()
                        .HasForeignKey("MusicId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Occupations")
                        .WithMany()
                        .HasForeignKey("OccupationsId");

                    b.HasOne("FamilySearchYouthAPI.Models.Region", null)
                        .WithMany("RegionalInformation")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Sports")
                        .WithMany()
                        .HasForeignKey("SportsId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Technology")
                        .WithMany()
                        .HasForeignKey("TechnologyId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Wars")
                        .WithMany()
                        .HasForeignKey("WarsId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Weather")
                        .WithMany()
                        .HasForeignKey("WeatherId");

                    b.HasOne("FamilySearchYouthAPI.Models.CardItem", "Wildlife")
                        .WithMany()
                        .HasForeignKey("WildlifeId");
                });
#pragma warning restore 612, 618
        }
    }
}
