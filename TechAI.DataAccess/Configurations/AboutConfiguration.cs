using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess.Configurations;

public class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.ToTable("Abouts");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(About.Id)).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(x => x.Title).HasColumnName(nameof(About.Title)).HasColumnType("nvarchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Content).HasColumnName(nameof(About.Content)).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(x => x.CreatedAt).HasColumnName(nameof(About.CreatedAt)).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.UpdatedAt).HasColumnName(nameof(About.UpdatedAt)).HasColumnType("datetime").IsRequired(false);
    }
}
