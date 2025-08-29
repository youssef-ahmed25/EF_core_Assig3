using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_Assig3.Migrations
{
    /// <inheritdoc />
    public partial class CoursinsWithRealtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Instructors",
                columns: table => new
                {
                    inst_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Instructors", x => new { x.inst_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Course_Instructors_Course_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Course",
                        principalColumn: "cors_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Instructors_Instructor_inst_ID",
                        column: x => x.inst_ID,
                        principalTable: "Instructor",
                        principalColumn: "ins_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Instructors_Course_ID",
                table: "Course_Instructors",
                column: "Course_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Instructors");
        }
    }
}
