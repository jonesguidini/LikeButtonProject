using LikeButtonProject.ButtonService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Data.Mappings
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(c => c.ArticleContent)
                .IsRequired()
                .HasColumnType("Varchar(max)");

            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasColumnType("Datetime");

            builder.Property(c => c.LastLikeAction)
                .HasColumnType("Datetime");

            builder.HasMany(a => a.Like).WithOne(b => b.Article);
        }
    }
}
