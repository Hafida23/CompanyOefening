using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyOefening.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    DepartmentNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.DepartmentNr);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectNr = table.Column<int>(name: "ProjectNr ", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectNr);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeNr = table.Column<int>(name: "EmployeeNr ", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeNr);
                    table.ForeignKey(
                        name: "FK_Employees_Departements_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departements",
                        principalColumn: "DepartmentNr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectNr ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departements",
                columns: new[] { "DepartmentNr", "EmployeeId", "Name" },
                values: new object[,]
                {
                    { 1, 0, "IT" },
                    { 2, 0, "HR" },
                    { 3, 0, "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectNr ", "Name" },
                values: new object[,]
                {
                    { 1, ".Net Developer" },
                    { 2, "Java Developer" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeNr ", "DepartmentId", "Name", "ProjectId" },
                values: new object[] { 1, 1, "Kenan Kurda", 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeNr ", "DepartmentId", "Name", "ProjectId" },
                values: new object[] { 2, 2, "Peral De Smet", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectId",
                table: "Employees",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departements");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
