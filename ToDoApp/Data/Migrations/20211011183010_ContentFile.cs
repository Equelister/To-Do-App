using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Data.Migrations
{
    public partial class ContentFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ContentFile",
                table: "TaskModel",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentFile",
                table: "TaskModel");
        }
    }
}
