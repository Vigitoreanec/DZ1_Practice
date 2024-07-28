using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DZ1_Practice.Migrations
{
    /// <inheritdoc />
    public partial class ChangeID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerJornals_Employees_EmployeeId",
                table: "WorkerJornals");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "WorkerJornals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerJornals_Employees_EmployeeId",
                table: "WorkerJornals",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerJornals_Employees_EmployeeId",
                table: "WorkerJornals");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "WorkerJornals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerJornals_Employees_EmployeeId",
                table: "WorkerJornals",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
