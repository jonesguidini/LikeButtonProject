﻿// <auto-generated />
using System;
using LikeButtonProject.ButtonService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LikeButtonProject.ButtonService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210122015253_InitialCommit")]
    partial class InitialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LikeButtonProject.ButtonService.Models.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasColumnType("Varchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("Datetime");

                    b.Property<DateTime?>("LastLikeAction")
                        .HasColumnType("Datetime");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a55e461f-3a18-492e-b37a-f6bca3b7e468"),
                            ArticleContent = "",
                            CreatedAt = new DateTime(2021, 1, 21, 22, 52, 52, 827, DateTimeKind.Local).AddTicks(4049),
                            LikesCount = 5,
                            Title = "Article 1"
                        },
                        new
                        {
                            Id = new Guid("be848242-6857-48bd-ba44-a097ed709e30"),
                            ArticleContent = "",
                            CreatedAt = new DateTime(2021, 1, 21, 22, 52, 52, 829, DateTimeKind.Local).AddTicks(3721),
                            LikesCount = 11,
                            Title = "Article 2"
                        },
                        new
                        {
                            Id = new Guid("a6edbd32-43a8-4da5-a651-1e0a6fcde225"),
                            ArticleContent = "",
                            CreatedAt = new DateTime(2021, 1, 21, 22, 52, 52, 829, DateTimeKind.Local).AddTicks(3787),
                            LikesCount = 3,
                            Title = "Article 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
