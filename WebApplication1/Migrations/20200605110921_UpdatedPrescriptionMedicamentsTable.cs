using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class UpdatedPrescriptionMedicamentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "PrescriptionMedicaments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dose",
                table: "PrescriptionMedicaments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "PrescriptionMedicaments");

            migrationBuilder.DropColumn(
                name: "Dose",
                table: "PrescriptionMedicaments");
        }
    }
}
