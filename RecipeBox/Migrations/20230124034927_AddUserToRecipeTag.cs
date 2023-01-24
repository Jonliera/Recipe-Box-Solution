using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipebox.Migrations
{
    public partial class AddUserToRecipeTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RecipeTags",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTags_UserId",
                table: "RecipeTags",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTags_AspNetUsers_UserId",
                table: "RecipeTags",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTags_AspNetUsers_UserId",
                table: "RecipeTags");

            migrationBuilder.DropIndex(
                name: "IX_RecipeTags_UserId",
                table: "RecipeTags");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RecipeTags");
        }
    }
}
