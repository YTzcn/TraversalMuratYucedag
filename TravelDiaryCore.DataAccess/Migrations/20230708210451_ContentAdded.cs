﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelDiaryCore.DataAccess.Migrations
{
    public partial class ContentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Destinations");
        }
    }
}
