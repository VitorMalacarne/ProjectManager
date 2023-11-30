﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OKRManager.Data;

#nullable disable

namespace OKRManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OkrManager.Models.KeyResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ObjectiveId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.ToTable("KeyResults");
                });

            modelBuilder.Entity("OkrManager.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("OkrManager.Models.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("KeyResultId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("KeyResultId");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("OkrManager.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OkrManager.Models.KeyResult", b =>
                {
                    b.HasOne("OkrManager.Models.Objective", null)
                        .WithMany("keyResults")
                        .HasForeignKey("ObjectiveId");
                });

            modelBuilder.Entity("OkrManager.Models.Objective", b =>
                {
                    b.HasOne("OkrManager.Models.User", null)
                        .WithMany("objectives")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("OkrManager.Models.SubTask", b =>
                {
                    b.HasOne("OkrManager.Models.KeyResult", null)
                        .WithMany("subTasks")
                        .HasForeignKey("KeyResultId");
                });

            modelBuilder.Entity("OkrManager.Models.KeyResult", b =>
                {
                    b.Navigation("subTasks");
                });

            modelBuilder.Entity("OkrManager.Models.Objective", b =>
                {
                    b.Navigation("keyResults");
                });

            modelBuilder.Entity("OkrManager.Models.User", b =>
                {
                    b.Navigation("objectives");
                });
#pragma warning restore 612, 618
        }
    }
}
