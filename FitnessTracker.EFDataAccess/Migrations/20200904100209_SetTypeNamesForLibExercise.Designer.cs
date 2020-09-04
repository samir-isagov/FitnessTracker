﻿// <auto-generated />
using System;
using FitnessTracker.EFDataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace FitnessTracker.EFDataAccess.Migrations
{
    [DbContext(typeof(FitnessTrackerContext))]
    [Migration("20200904100209_SetTypeNamesForLibExercise")]
    partial class SetTypeNamesForLibExercise
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("FitnessTracker.EFDataAccess.Models.FinishedExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories")
                        .HasMaxLength(4);

                    b.Property<int>("Duration")
                        .HasMaxLength(4);

                    b.Property<int?>("ExerciseId");

                    b.Property<int?>("StateId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("StateId");

                    b.HasIndex("UserId");

                    b.ToTable("FinishedExercises");
                });

            modelBuilder.Entity("FitnessTracker.EFDataAccess.Models.LibExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories")
                        .HasColumnType("NUMBER(11)")
                        .HasMaxLength(4);

                    b.Property<int>("Duration")
                        .HasColumnType("NUMBER(11)")
                        .HasMaxLength(4);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("LibExercises");
                });

            modelBuilder.Entity("FitnessTracker.EFDataAccess.Models.LibExerciseState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("LibExerciseStates");
                });

            modelBuilder.Entity("FitnessTracker.EFDataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitnessTracker.EFDataAccess.Models.FinishedExercise", b =>
                {
                    b.HasOne("FitnessTracker.EFDataAccess.Models.LibExercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");

                    b.HasOne("FitnessTracker.EFDataAccess.Models.LibExerciseState", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("FitnessTracker.EFDataAccess.Models.User")
                        .WithMany("FinishedExercises")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}