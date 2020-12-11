﻿// <auto-generated />
using System;
using AmerFamilyPlayoffs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmerFamilyPlayoffs.Data.Migrations
{
    [DbContext(typeof(AmerFamilyPlayoffContext))]
    partial class AmerFamilyPlayoffContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Matchup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayoffRoundId")
                        .HasColumnType("int");

                    b.Property<int?>("RoundId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("PlayoffRoundId");

                    b.HasIndex("RoundId");

                    b.ToTable("Matchups");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Playoff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Playoffs");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.PlayoffRound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PlayoffId")
                        .HasColumnType("int");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayoffId");

                    b.HasIndex("RoundId");

                    b.ToTable("PlayoffRounds");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.SeasonTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TeamId");

                    b.ToTable("SeasonTeams");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Location")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Matchup", b =>
                {
                    b.HasOne("AmerFamilyPlayoffs.Data.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmerFamilyPlayoffs.Data.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmerFamilyPlayoffs.Data.PlayoffRound", null)
                        .WithMany("Matchups")
                        .HasForeignKey("PlayoffRoundId");

                    b.HasOne("AmerFamilyPlayoffs.Data.Round", null)
                        .WithMany("Matchups")
                        .HasForeignKey("RoundId");

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Playoff", b =>
                {
                    b.HasOne("AmerFamilyPlayoffs.Data.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.PlayoffRound", b =>
                {
                    b.HasOne("AmerFamilyPlayoffs.Data.Playoff", "Playoff")
                        .WithMany()
                        .HasForeignKey("PlayoffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmerFamilyPlayoffs.Data.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playoff");

                    b.Navigation("Round");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.SeasonTeam", b =>
                {
                    b.HasOne("AmerFamilyPlayoffs.Data.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmerFamilyPlayoffs.Data.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.PlayoffRound", b =>
                {
                    b.Navigation("Matchups");
                });

            modelBuilder.Entity("AmerFamilyPlayoffs.Data.Round", b =>
                {
                    b.Navigation("Matchups");
                });
#pragma warning restore 612, 618
        }
    }
}
