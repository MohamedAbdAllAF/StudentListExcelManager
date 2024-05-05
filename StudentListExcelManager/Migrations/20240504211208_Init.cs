using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentListExcelManager.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameArabic = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    NameEnglish = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    NationalID = table.Column<string>(type: "TEXT", maxLength: 14, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    ConfirmPasswor = table.Column<string>(type: "TEXT", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<short>(type: "INTEGER", nullable: false),
                    StudentCode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Nationality = table.Column<int>(type: "INTEGER", nullable: false),
                    Religion = table.Column<short>(type: "INTEGER", nullable: false),
                    ReleasePlace = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false),
                    GovernorateId = table.Column<int>(type: "INTEGER", nullable: false),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    PreQualification = table.Column<string>(type: "TEXT", nullable: true),
                    SeatNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    QualificationYear = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Degree = table.Column<decimal>(type: "TEXT", nullable: true),
                    ParentName = table.Column<string>(type: "TEXT", nullable: false),
                    ParentJob = table.Column<string>(type: "TEXT", nullable: false),
                    ParentCountryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentGovernorateId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentCityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentStreet = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCodeOfParent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Type = table.Column<short>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_StudentId",
                table: "Phones",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
