using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_NewSolutions.Migrations
{
    public partial class add_project_details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "details",
                schema: "projects",
                table: "upload_project",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "details",
                schema: "projects",
                table: "upload_project");
        }
    }
}
