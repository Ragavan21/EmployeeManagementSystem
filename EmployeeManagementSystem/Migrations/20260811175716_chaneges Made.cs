using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class chanegesMade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DesignationId",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "DesignationId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "DesignationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "DesignationId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DesignationId",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "DesignationId");
        }
    }
}
