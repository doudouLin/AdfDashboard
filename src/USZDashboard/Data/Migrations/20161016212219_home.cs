using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace USZDashboard.Data.Migrations
{
    public partial class home : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Structure",
                table: "Dashboard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Structure",
                table: "Dashboard");
        }
    }
}
