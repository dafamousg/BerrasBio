using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BerrasBio.Migrations
{
    public partial class Al : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RunningMinutes",
                table: "Movies");
        }
    }
}
