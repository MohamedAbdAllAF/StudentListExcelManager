﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentListExcelManager.Models;

#nullable disable

namespace StudentListExcelManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.29");

            modelBuilder.Entity("StudentListExcelManager.Models.Phone", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<short>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("StudentListExcelManager.Models.Student", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmPasswor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Degree")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameArabic")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("NameEnglish")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<int>("Nationality")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentCityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentCountryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentGovernorateId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParentJob")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentStreet")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCodeOfParent")
                        .HasColumnType("TEXT");

                    b.Property<string>("PreQualification")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("QualificationYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReleasePlace")
                        .HasColumnType("TEXT");

                    b.Property<short>("Religion")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SeatNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentListExcelManager.Models.Phone", b =>
                {
                    b.HasOne("StudentListExcelManager.Models.Student", "Student")
                        .WithMany("Phones")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentListExcelManager.Models.Student", b =>
                {
                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
