using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DZ1_Practice.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_WorkerJornals_WorkerJornalId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkerJornalId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkerJornalId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "WorkerJornals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerJornals_EmployeeId",
                table: "WorkerJornals",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerJornals_Employees_EmployeeId",
                table: "WorkerJornals",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerJornals_Employees_EmployeeId",
                table: "WorkerJornals");

            migrationBuilder.DropIndex(
                name: "IX_WorkerJornals_EmployeeId",
                table: "WorkerJornals");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "WorkerJornals");

            migrationBuilder.AddColumn<int>(
                name: "WorkerJornalId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkerJornalId",
                table: "Employees",
                column: "WorkerJornalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_WorkerJornals_WorkerJornalId",
                table: "Employees",
                column: "WorkerJornalId",
                principalTable: "WorkerJornals",
                principalColumn: "Id");
        }
    }
}
