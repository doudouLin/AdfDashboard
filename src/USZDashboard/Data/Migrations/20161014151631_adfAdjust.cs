using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace USZDashboard.Data.Migrations
{
    public partial class adfAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Dashboard",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "categories",
                table: "Dashboard",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "collapsible",
                table: "Dashboard",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "editable",
                table: "Dashboard",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "maximizable",
                table: "Dashboard",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Dashboard");

            migrationBuilder.DropColumn(
                name: "categories",
                table: "Dashboard");

            migrationBuilder.DropColumn(
                name: "collapsible",
                table: "Dashboard");

            migrationBuilder.DropColumn(
                name: "editable",
                table: "Dashboard");

            migrationBuilder.DropColumn(
                name: "maximizable",
                table: "Dashboard");
        }
    }
}
