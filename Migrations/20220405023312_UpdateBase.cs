using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIResources.Migrations
{
    public partial class UpdateBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateChange",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegister",
                table: "Resources",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdRespChange",
                table: "Resources",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRespRegistration",
                table: "Resources",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateChange",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DateRegister",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "IdRespChange",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "IdRespRegistration",
                table: "Resources");
        }
    }
}
