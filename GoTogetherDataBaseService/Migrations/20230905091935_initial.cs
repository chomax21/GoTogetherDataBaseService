using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoTogetherDataBaseService.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    RegDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HomeOrStreet = table.Column<int>(type: "integer", nullable: false),
                    VideoGames = table.Column<int>(type: "integer", nullable: false),
                    FoodHealthyOrDelicous = table.Column<int>(type: "integer", nullable: false),
                    SportOrSofa = table.Column<int>(type: "integer", nullable: false),
                    StudyOrEntartaiment = table.Column<int>(type: "integer", nullable: false),
                    ManyPeopleOrLonely = table.Column<int>(type: "integer", nullable: false),
                    CityOrNature = table.Column<int>(type: "integer", nullable: false),
                    WalkOrTransport = table.Column<int>(type: "integer", nullable: false),
                    TalkOrListen = table.Column<int>(type: "integer", nullable: false),
                    BadHabits = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userProperties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userProperties_UserId",
                table: "userProperties",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userProperties");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
