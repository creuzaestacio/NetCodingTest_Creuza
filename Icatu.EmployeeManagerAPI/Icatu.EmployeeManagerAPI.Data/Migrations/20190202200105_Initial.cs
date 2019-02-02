using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Icatu.EmployeeManagerAPI.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_EMPLOYEE",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EMPLOYEE", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_EMPLOYEE");
        }
    }
}
