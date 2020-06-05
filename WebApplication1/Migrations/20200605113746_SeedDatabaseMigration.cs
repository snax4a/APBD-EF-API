using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebApplication1.Migrations
{
    public partial class SeedDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "FirstName", "LastName", "Email" },
                values: new object[,]
                {
                    { 1, "Adam", "Kowal", "example1@gmail.com" },
                    { 2, "Anna", "Nowak", "example2@gmail.com" },
                    { 3, "Mariusz", "Potoczny", "example3@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Name", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "APAP", "glupi opis", "tabletki" },
                    { 2, "Fajny lek.", "opis fajnego leku", "tabletki" },
                    { 3, "Syrop", "Syrop na kaszel", "syropy" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "FirstName", "LastName", "BirthDate", },
                values: new object[,]
                {
                    { 1, "Katarzyna", "Bator", new DateTime(1975, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Szymon", "Boczar", new DateTime(1997, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Karolina", "Dupa", new DateTime(1999, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 3, 1, "Codziennie po obiedzie", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "Doctors",
               keyColumn: "IdDoctor",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrescribedMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);
        }
    }
}
