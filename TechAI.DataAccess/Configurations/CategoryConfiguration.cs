using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(Category.Id)).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(x => x.Name).HasColumnName(nameof(Category.Name)).HasColumnType("nvarchar(100)").HasMaxLength(60).IsRequired();
        builder.Property(x => x.CreatedAt).HasColumnName(nameof(Category.CreatedAt)).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.UpdatedAt).HasColumnName(nameof(Category.UpdatedAt)).HasColumnType("datetime").IsRequired(false);
    }
}
