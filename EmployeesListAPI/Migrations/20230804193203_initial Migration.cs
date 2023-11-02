using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesListAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeRef",
                columns: table => new
                {
                    CodeType = table.Column<string>(type: "varchar(10)", nullable: false),
                    Code = table.Column<string>(type: "varchar(10)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "varchar(500)", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeRef", x => new { x.CodeType, x.Code });
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    CompanyCode = table.Column<string>(type: "varchar(10)", nullable: false),
                    EmpCode = table.Column<string>(type: "varchar(10)", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(100)", nullable: false),
                    AliasName = table.Column<string>(type: "varchar(100)", nullable: false),
                    ICNO = table.Column<string>(type: "varchar(20)", nullable: true),
                    SectionCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    DepartmentCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    DesignationCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "varchar(500)", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => new { x.CompanyCode, x.EmpCode });
                });

            migrationBuilder.CreateTable(
               name: "Company",
               columns: table => new
               {
                   CompanyCode = table.Column<string>(type: "varchar(10)", nullable: false),
                   CompanyName = table.Column<string>(type: "varchar(500)", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Company", x => x.CompanyCode);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeRef");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
