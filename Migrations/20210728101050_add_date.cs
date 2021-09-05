using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_NewSolutions.Migrations
{
    public partial class add_date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                schema: "projects",
                table: "upload_project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                schema: "projects",
                table: "upload_project");
        }
    }
}
