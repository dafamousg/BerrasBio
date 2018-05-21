using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BerrasBio.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RunningMinutes",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RunningMinutes",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }
    }
}
