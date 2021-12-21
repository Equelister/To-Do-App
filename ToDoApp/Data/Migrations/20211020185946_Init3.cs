using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Data.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileModel_TaskModel_taskId",
                table: "FileModel");

            migrationBuilder.DropIndex(
                name: "IX_FileModel_taskId",
                table: "FileModel");

            migrationBuilder.AddColumn<int>(
                name: "parentTaskID",
                table: "FileModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileModel_parentTaskID",
                table: "FileModel",
                column: "parentTaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_FileModel_TaskModel_parentTaskID",
                table: "FileModel",
                column: "parentTaskID",
                principalTable: "TaskModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileModel_TaskModel_parentTaskID",
                table: "FileModel");

            migrationBuilder.DropIndex(
                name: "IX_FileModel_parentTaskID",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "parentTaskID",
                table: "FileModel");

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
    }
}
