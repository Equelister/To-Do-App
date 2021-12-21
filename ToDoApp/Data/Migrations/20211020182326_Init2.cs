using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Data.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilesOnDatabase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilesOnFileSystem",
                table: "FilesOnFileSystem");

            migrationBuilder.DropColumn(
                name: "ContentFile",
                table: "TaskModel");

            migrationBuilder.RenameTable(
                name: "FilesOnFileSystem",
                newName: "FileModel");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "FileModel",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "FileModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "taskId",
                table: "FileModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileModel",
                table: "FileModel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FileModel_taskId",
                table: "FileModel",
                column: "taskId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileModel_TaskModel_taskId",
                table: "FileModel",
                column: "taskId",
                principalTable: "TaskModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileModel_TaskModel_taskId",
                table: "FileModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileModel",
                table: "FileModel");

            migrationBuilder.DropIndex(
                name: "IX_FileModel_taskId",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "taskId",
                table: "FileModel");

            migrationBuilder.RenameTable(
                name: "FileModel",
                newName: "FilesOnFileSystem");

            migrationBuilder.AddColumn<byte[]>(
                name: "ContentFile",
                table: "TaskModel",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilesOnFileSystem",
                table: "FilesOnFileSystem",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOnDatabase", x => x.Id);
                });
        }
    }
}
