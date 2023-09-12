using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoTogetherDataBaseService.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userProperties_Users_UserId",
                table: "userProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userProperties",
                table: "userProperties");

            migrationBuilder.RenameTable(
                name: "userProperties",
                newName: "UserProperties");

            migrationBuilder.RenameIndex(
                name: "IX_userProperties_UserId",
                table: "UserProperties",
                newName: "IX_UserProperties_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProperties",
                table: "UserProperties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProperties_Users_UserId",
                table: "UserProperties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProperties_Users_UserId",
                table: "UserProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProperties",
                table: "UserProperties");

            migrationBuilder.RenameTable(
                name: "UserProperties",
                newName: "userProperties");

            migrationBuilder.RenameIndex(
                name: "IX_UserProperties_UserId",
                table: "userProperties",
                newName: "IX_userProperties_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userProperties",
                table: "userProperties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userProperties_Users_UserId",
                table: "userProperties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
