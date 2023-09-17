using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoTogetherDataBaseService.Migrations
{
    /// <inheritdoc />
    public partial class delteNavigations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProperties_Users_UserId",
                table: "UserProperties");

            migrationBuilder.DropIndex(
                name: "IX_UserProperties_UserId",
                table: "UserProperties");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserProperties");

            migrationBuilder.AddColumn<int>(
                name: "userPropertiesId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_userPropertiesId",
                table: "Users",
                column: "userPropertiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserProperties_userPropertiesId",
                table: "Users",
                column: "userPropertiesId",
                principalTable: "UserProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserProperties_userPropertiesId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_userPropertiesId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userPropertiesId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserProperties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserProperties_UserId",
                table: "UserProperties",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProperties_Users_UserId",
                table: "UserProperties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
