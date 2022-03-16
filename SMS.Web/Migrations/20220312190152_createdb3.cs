using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Web.Migrations
{
    public partial class createdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTimeRegister",
                table: "tagrecive",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "current_timestamp",
                oldClrType: typeof(DateTime),
                oldType: "timestamp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTimeRegister",
                table: "tagrecive",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "current_timestamp");
        }
    }
}
