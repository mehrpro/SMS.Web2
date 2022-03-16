using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Web.Migrations
{
    public partial class createdb33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Dublicate",
                table: "tagrecive",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StudentID_FK",
                table: "tagrecive",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagID_FK",
                table: "tagrecive",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dublicate",
                table: "tagrecive");

            migrationBuilder.DropColumn(
                name: "StudentID_FK",
                table: "tagrecive");

            migrationBuilder.DropColumn(
                name: "TagID_FK",
                table: "tagrecive");
        }
    }
}
