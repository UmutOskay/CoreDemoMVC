using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogeCreateDate",
                table: "Blogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "BlogCreateDate",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogCreateDate",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "BlogeCreateDate",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
