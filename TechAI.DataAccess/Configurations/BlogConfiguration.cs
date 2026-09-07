using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blogs");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(Blog.Id)).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(x => x.Title).HasColumnName(nameof(Blog.Title)).HasColumnType("nvarchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.CoverImageUrl).HasColumnName(nameof(Blog.CoverImageUrl)).HasColumnType("nvarchar(200)").HasMaxLength(200).IsRequired();
        builder.Property(x => x.MainImageUrl).HasColumnName(nameof(Blog.MainImageUrl)).HasColumnType("nvarchar(200)").HasMaxLength(200).IsRequired();
        builder.Property(x => x.Content).HasColumnName(nameof(Blog.Content)).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(x => x.CreatedAt).HasColumnName(nameof(Blog.CreatedAt)).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.UpdatedAt).HasColumnName(nameof(Blog.UpdatedAt)).HasColumnType("datetime").IsRequired(false);
    }
}
