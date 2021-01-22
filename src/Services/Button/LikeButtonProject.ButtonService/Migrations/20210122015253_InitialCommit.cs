using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeButtonProject.ButtonService.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    ArticleContent = table.Column<string>(type: "Varchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: false),
                    LastLikeAction = table.Column<DateTime>(type: "Datetime", nullable: true),
                    LikesCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
