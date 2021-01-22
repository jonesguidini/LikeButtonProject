using LikeButtonProject.ButtonService.Models;
using LikeButtonProject.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Data
{
    public class DataContext : DbContext, IUnitOfWork
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly); 

            /*
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = Guid.Parse("A55E461F-3A18-492E-B37A-F6BCA3B7E468"),
                    Title = "Article 1",
                    ArticleContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet pellentesque elit. Donec ultricies eleifend dictum. Proin sed nisi mattis, ornare augue eget, volutpat purus. Integer ipsum magna, eleifend nec accumsan eget, lobortis ut est. Duis sit amet mauris euismod, mattis nulla nec, congue nunc. Integer non rutrum ante. In id eros sem. Quisque luctus sem elit, et iaculis eros scelerisque quis. Fusce a feugiat leo. Sed ante lectus, pellentesque nec turpis eu, scelerisque porttitor tellus. Vestibulum porta, tortor ut commodo porta, lorem eros ultrices sapien, in luctus metus velit vel ante. Aenean auctor eget ex in consectetur. Aenean volutpat tristique dui, non dapibus libero scelerisque eget.",
                    CreatedAt = DateTime.Now,
                    LikesCount = 5
                },
                new Article
                {
                    Id = Guid.Parse("BE848242-6857-48BD-BA44-A097ED709E30"),
                    Title = "Article 2",
                    ArticleContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet pellentesque elit. Donec ultricies eleifend dictum. Proin sed nisi mattis, ornare augue eget, volutpat purus. Integer ipsum magna, eleifend nec accumsan eget, lobortis ut est. Duis sit amet mauris euismod, mattis nulla nec, congue nunc. Integer non rutrum ante. In id eros sem. Quisque luctus sem elit, et iaculis eros scelerisque quis. Fusce a feugiat leo. Sed ante lectus, pellentesque nec turpis eu, scelerisque porttitor tellus. Vestibulum porta, tortor ut commodo porta, lorem eros ultrices sapien, in luctus metus velit vel ante. Aenean auctor eget ex in consectetur. Aenean volutpat tristique dui, non dapibus libero scelerisque eget.",
                    CreatedAt = DateTime.Now,
                    LikesCount = 11
                },
                new Article
                {
                    Id = Guid.Parse("A6EDBD32-43A8-4DA5-A651-1E0A6FCDE225"),
                    Title = "Article 3",
                    ArticleContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet pellentesque elit. Donec ultricies eleifend dictum. Proin sed nisi mattis, ornare augue eget, volutpat purus. Integer ipsum magna, eleifend nec accumsan eget, lobortis ut est. Duis sit amet mauris euismod, mattis nulla nec, congue nunc. Integer non rutrum ante. In id eros sem. Quisque luctus sem elit, et iaculis eros scelerisque quis. Fusce a feugiat leo. Sed ante lectus, pellentesque nec turpis eu, scelerisque porttitor tellus. Vestibulum porta, tortor ut commodo porta, lorem eros ultrices sapien, in luctus metus velit vel ante. Aenean auctor eget ex in consectetur. Aenean volutpat tristique dui, non dapibus libero scelerisque eget.",
                    CreatedAt = DateTime.Now,
                    LikesCount = 3
                }
                );*/
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
