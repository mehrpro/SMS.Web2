using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Web.Migrations
{
    public partial class createdb333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Registered",
                table: "tagrecive");

            migrationBuilder.AddColumn<int>(
                name: "Delivery",
                table: "tagrecive",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "sending",
                table: "tagrecive",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "tagrecive");

            migrationBuilder.DropColumn(
                name: "sending",
                table: "tagrecive");

            migrationBuilder.AddColumn<bool>(
                name: "Registered",
                table: "tagrecive",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: true);
        }
    }
}
