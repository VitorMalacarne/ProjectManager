﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OKRManager.Data;

#nullable disable

namespace OKRManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231204232052_teste1")]
    partial class teste1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OkrManager.Models.KeyResult", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("KeyResult");
                });

            modelBuilder.Entity("OkrManager.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Objective");
                });

            modelBuilder.Entity("OkrManager.Models.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SubTask");
                });

            modelBuilder.Entity("OkrManager.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OkrManager.Models.KeyResult", b =>
                {
                    b.HasOne("OkrManager.Models.Objective", "RelatedObjective")
                        .WithMany("KeyResults")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedObjective");
                });

            modelBuilder.Entity("OkrManager.Models.Objective", b =>
                {
                    b.HasOne("OkrManager.Models.User", "RelatedUser")
                        .WithMany("Objectives")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedUser");
                });

            modelBuilder.Entity("OkrManager.Models.SubTask", b =>
                {
                    b.HasOne("OkrManager.Models.KeyResult", "RelatedKeyResult")
                        .WithMany("SubTasks")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedKeyResult");
                });

            modelBuilder.Entity("OkrManager.Models.KeyResult", b =>
                {
                    b.Navigation("SubTasks");
                });

            modelBuilder.Entity("OkrManager.Models.Objective", b =>
                {
                    b.Navigation("KeyResults");
                });

            modelBuilder.Entity("OkrManager.Models.User", b =>
                {
                    b.Navigation("Objectives");
                });
#pragma warning restore 612, 618
        }
    }
}
