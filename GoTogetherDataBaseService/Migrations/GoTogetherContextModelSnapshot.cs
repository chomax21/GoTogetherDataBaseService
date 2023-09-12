﻿// <auto-generated />
using System;
using GoTogetherDataBaseService.Data.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoTogetherDataBaseService.Migrations
{
    [DbContext(typeof(GoTogetherContext))]
    partial class GoTogetherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GoTogetherDataBaseService.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RegDay")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GoTogetherDataBaseService.Data.Models.UserProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BadHabits")
                        .HasColumnType("integer");

                    b.Property<int>("CityOrNature")
                        .HasColumnType("integer");

                    b.Property<int>("FoodHealthyOrDelicous")
                        .HasColumnType("integer");

                    b.Property<int>("HomeOrStreet")
                        .HasColumnType("integer");

                    b.Property<int>("ManyPeopleOrLonely")
                        .HasColumnType("integer");

                    b.Property<int>("SportOrSofa")
                        .HasColumnType("integer");

                    b.Property<int>("StudyOrEntartaiment")
                        .HasColumnType("integer");

                    b.Property<int>("TalkOrListen")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("VideoGames")
                        .HasColumnType("integer");

                    b.Property<int>("WalkOrTransport")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProperties");
                });

            modelBuilder.Entity("GoTogetherDataBaseService.Data.Models.UserProperties", b =>
                {
                    b.HasOne("GoTogetherDataBaseService.Data.Models.User", "User")
                        .WithOne("userProperties")
                        .HasForeignKey("GoTogetherDataBaseService.Data.Models.UserProperties", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GoTogetherDataBaseService.Data.Models.User", b =>
                {
                    b.Navigation("userProperties")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
