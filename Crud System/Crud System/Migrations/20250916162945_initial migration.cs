using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_System.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StuAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StuSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StuAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
