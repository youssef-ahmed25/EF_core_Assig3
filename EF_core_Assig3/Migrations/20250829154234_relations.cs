using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_Assig3.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_Course_ID",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_stud_ID",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_Course_ID",
                table: "Stud_Course",
                newName: "IX_Stud_Course_Course_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructor",
                newName: "IX_Instructor_Dept_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "ins_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "dept_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "cors_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Department",
                principalColumn: "dept_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "cors_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_stud_ID",
                table: "Stud_Course",
                column: "stud_ID",
                principalTable: "Student",
                principalColumn: "stud_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_Course_ID",
                table: "StudentCourses",
                newName: "IX_StudentCourses_Course_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructors",
                newName: "IX_Instructors_Dept_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "ins_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "dept_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "cors_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "dept_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_Course_ID",
                table: "StudentCourses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "cors_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_stud_ID",
                table: "StudentCourses",
                column: "stud_ID",
                principalTable: "Students",
                principalColumn: "stud_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
