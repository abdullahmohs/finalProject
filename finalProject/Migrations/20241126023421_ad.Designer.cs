﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalProject.Data;

#nullable disable

namespace finalProject.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20241126023421_ad")]
    partial class ad
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("finalProject.Data.AI_Compulsory", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("AI Requirements_Compulsory");
                });

            modelBuilder.Entity("finalProject.Data.AI_Electives", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("AI Requirements_Electives");
                });

            modelBuilder.Entity("finalProject.Data.CS_Compulsory", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("CS Requirements_Compulsory");
                });

            modelBuilder.Entity("finalProject.Data.CS_Electives", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("CS Requirements_Electives");
                });

            modelBuilder.Entity("finalProject.Data.Faculty_Compulsory", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("Faculty Requirements_Compulsory");
                });

            modelBuilder.Entity("finalProject.Data.Faculty_Electives", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("Faculty Requirements_Electives");
                });

            modelBuilder.Entity("finalProject.Data.General_Compulsory", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("General Requirements_Compulsory");
                });

            modelBuilder.Entity("finalProject.Data.General_Electives", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("General Requirements_Electives");
                });

            modelBuilder.Entity("finalProject.Data.IS_Compulsory", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("IS Requirements_Compulsory");
                });

            modelBuilder.Entity("finalProject.Data.IS_Electives", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("IS Requirements_Electives");
                });

            modelBuilder.Entity("finalProject.Data.IT_Compulsory", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("IT Requirements_Compulsory");
                });

            modelBuilder.Entity("finalProject.Data.IT_Electives", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prerequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("IT Requirements_Electives");
                });

            modelBuilder.Entity("finalProject.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("department")
                        .HasColumnType("longtext");

                    b.Property<float?>("gpa")
                        .HasColumnType("float");

                    b.Property<int?>("hours")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("level")
                        .HasColumnType("longtext");

                    b.Property<string>("profilePic")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("finalProject.Data.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("grade")
                        .HasColumnType("longtext");

                    b.HasKey("StudentId", "SubjectCode");

                    b.HasIndex("SubjectCode");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("finalProject.Data.Subject", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("hours")
                        .HasColumnType("int");

                    b.HasKey("code");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("finalProject.Data.StudentSubject", b =>
                {
                    b.HasOne("finalProject.Data.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("finalProject.Data.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("finalProject.Data.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("finalProject.Data.Subject", b =>
                {
                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
