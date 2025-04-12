using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ENF_Project.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessionAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseSessionId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessionAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSessions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instances_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "ManagerId", "Name" },
                values: new object[,]
                {
                    { 1, "Building A", null, "Computer Science" },
                    { 2, "Building B", null, "Mathematics" },
                    { 3, "Building C", null, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "John", "Doe", "444-4444" },
                    { 2, "Jane", "Smith", "555-5555" },
                    { 3, "Mike", "Johnson", "666-6666" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "Alice", "Anderson", "111-1111" },
                    { 2, 2, "Bob", "Brown", "222-2222" },
                    { 3, 3, "Charlie", "Clark", "333-3333" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "DepartmentId", "Duration", "InstructorId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 40, 1, "Intro to Programming" },
                    { 2, 1, 60, 1, "Advanced Algorithms" },
                    { 3, 2, 45, 2, "Calculus I" },
                    { 4, 3, 50, 3, "Physics I" }
                });

            migrationBuilder.InsertData(
                table: "CourseSessions",
                columns: new[] { "Id", "CourseId", "Date", "InstructorId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Introduction to C#" },
                    { 2, 2, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Data Structures" },
                    { 3, 3, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Calculus I" },
                    { 4, 4, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Physics I" }
                });

            migrationBuilder.InsertData(
                table: "CourseSessionAttendances",
                columns: new[] { "Id", "CourseSessionId", "Grade", "Notes", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 85, "Active participation", 1 },
                    { 2, 1, 90, "Excellent work", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_CourseSessionId",
                table: "CourseSessionAttendances",
                column: "CourseSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_StudentId",
                table: "CourseSessionAttendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_CourseId",
                table: "CourseSessions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_InstructorId",
                table: "CourseSessions",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_DepartmentId",
                table: "Instances",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instances_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_CourseSessions_CourseSessionId",
                table: "CourseSessionAttendances",
                column: "CourseSessionId",
                principalTable: "CourseSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Instances_InstructorId",
                table: "CourseSessions",
                column: "InstructorId",
                principalTable: "Instances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instances_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Instances",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instances_Departments_DepartmentId",
                table: "Instances");

            migrationBuilder.DropTable(
                name: "CourseSessionAttendances");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "CourseSessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instances");
        }
    }
}
