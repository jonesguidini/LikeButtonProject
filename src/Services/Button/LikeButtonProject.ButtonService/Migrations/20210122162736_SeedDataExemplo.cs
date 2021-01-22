using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LikeButtonProject.ButtonService.Migrations
{
    public partial class SeedDataExemplo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleContent", "CreatedAt", "LastLikeAction", "Title" },
                values: new object[] { new Guid("a55e461f-3a18-492e-b37a-f6bca3b7e468"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet pellentesque elit. Donec ultricies eleifend dictum. Proin sed nisi mattis, ornare augue eget, volutpat purus. Integer ipsum magna, eleifend nec accumsan eget, lobortis ut est. Duis sit amet mauris euismod, mattis nulla nec, congue nunc. Integer non rutrum ante. In id eros sem. Quisque luctus sem elit, et iaculis eros scelerisque quis. Fusce a feugiat leo. Sed ante lectus, pellentesque nec turpis eu, scelerisque porttitor tellus. Vestibulum porta, tortor ut commodo porta, lorem eros ultrices sapien, in luctus metus velit vel ante. Aenean auctor eget ex in consectetur. Aenean volutpat tristique dui, non dapibus libero scelerisque eget.", "2021-01-21T18:10:00", null, "Article 1" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleContent", "CreatedAt", "LastLikeAction", "Title" },
                values: new object[] { new Guid("be848242-6857-48bd-ba44-a097ed709e30"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet pellentesque elit. Donec ultricies eleifend dictum. Proin sed nisi mattis, ornare augue eget, volutpat purus. Integer ipsum magna, eleifend nec accumsan eget, lobortis ut est. Duis sit amet mauris euismod, mattis nulla nec, congue nunc. Integer non rutrum ante. In id eros sem. Quisque luctus sem elit, et iaculis eros scelerisque quis. Fusce a feugiat leo. Sed ante lectus, pellentesque nec turpis eu, scelerisque porttitor tellus. Vestibulum porta, tortor ut commodo porta, lorem eros ultrices sapien, in luctus metus velit vel ante. Aenean auctor eget ex in consectetur. Aenean volutpat tristique dui, non dapibus libero scelerisque eget.", "2021-01-21T18:10:00", null, "Article 2" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleContent", "CreatedAt", "LastLikeAction", "Title" },
                values: new object[] { new Guid("a6edbd32-43a8-4da5-a651-1e0a6fcde225"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet pellentesque elit. Donec ultricies eleifend dictum. Proin sed nisi mattis, ornare augue eget, volutpat purus. Integer ipsum magna, eleifend nec accumsan eget, lobortis ut est. Duis sit amet mauris euismod, mattis nulla nec, congue nunc. Integer non rutrum ante. In id eros sem. Quisque luctus sem elit, et iaculis eros scelerisque quis. Fusce a feugiat leo. Sed ante lectus, pellentesque nec turpis eu, scelerisque porttitor tellus. Vestibulum porta, tortor ut commodo porta, lorem eros ultrices sapien, in luctus metus velit vel ante. Aenean auctor eget ex in consectetur. Aenean volutpat tristique dui, non dapibus libero scelerisque eget.", "2021-01-21T18:10:00", null, "Article 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a55e461f-3a18-492e-b37a-f6bca3b7e468"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a6edbd32-43a8-4da5-a651-1e0a6fcde225"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("be848242-6857-48bd-ba44-a097ed709e30"));
        }
    }
}
