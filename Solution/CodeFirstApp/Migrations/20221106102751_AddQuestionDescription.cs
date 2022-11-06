﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    public partial class AddQuestionDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Questions");
        }
    }
}
