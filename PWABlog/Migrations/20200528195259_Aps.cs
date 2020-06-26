using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PWABlog.Migrations
{
    public partial class Aps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataExibicao",
                table: "Postagens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataExibicao",
                table: "Postagens");
        }
    }
}
