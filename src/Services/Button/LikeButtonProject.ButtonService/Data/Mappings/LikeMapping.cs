using LikeButtonProject.ButtonService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Data.Mappings
{
    public class LikeMapping : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(a => a.Article).WithMany(b => b.Like);

            builder.Property(c => c.UserIP)
                .HasColumnType("varchar(15)");
        }
    }
}
