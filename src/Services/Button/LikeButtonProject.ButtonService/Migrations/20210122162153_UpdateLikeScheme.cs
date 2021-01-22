using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeButtonProject.ButtonService.Migrations
{
    public partial class UpdateLikeScheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "Articles");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: true),
                    UserIP = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ArticleId",
                table: "Likes",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleContent", "CreatedAt", "LastLikeAction", "LikesCount", "Title" },
                values: new object[] { new Guid("a55e461f-3a18-492e-b37a-f6bca3b7e468"), "", new DateTime(2021, 1, 21, 22, 52, 52, 827, DateTimeKind.Local).AddTicks(4049), null, 5, "Article 1" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleContent", "CreatedAt", "LastLikeAction", "LikesCount", "Title" },
                values: new object[] { new Guid("be848242-6857-48bd-ba44-a097ed709e30"), "", new DateTime(2021, 1, 21, 22, 52, 52, 829, DateTimeKind.Local).AddTicks(3721), null, 11, "Article 2" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleContent", "CreatedAt", "LastLikeAction", "LikesCount", "Title" },
                values: new object[] { new Guid("a6edbd32-43a8-4da5-a651-1e0a6fcde225"), "", new DateTime(2021, 1, 21, 22, 52, 52, 829, DateTimeKind.Local).AddTicks(3787), null, 3, "Article 3" });
        }
    }
}
