using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_Assig3.Migrations
{
    /// <inheritdoc />
    public partial class deptidAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_ID",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stuDepartmentdept_ID",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_stuDepartmentdept_ID",
                table: "Student",
                column: "stuDepartmentdept_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_stuDepartmentdept_ID",
                table: "Student",
                column: "stuDepartmentdept_ID",
                principalTable: "Department",
                principalColumn: "dept_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_stuDepartmentdept_ID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_stuDepartmentdept_ID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Dept_ID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "stuDepartmentdept_ID",
                table: "Student");
        }
    }
}
