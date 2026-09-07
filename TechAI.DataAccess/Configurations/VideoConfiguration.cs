using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess.Configurations;

public class VideoConfiguration : IEntityTypeConfiguration<Video>
{
    public void Configure(EntityTypeBuilder<Video> builder)
    {
        builder.ToTable("Videos");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(Video.Id)).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(x => x.Title).HasColumnName(nameof(Video.Title)).HasColumnType("nvarchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.ThumbnailImageUrl).HasColumnName(nameof(Video.ThumbnailImageUrl)).HasColumnType("nvarchar(200)").HasMaxLength(200).IsRequired();
        builder.Property(x => x.EmbeddedVideoUrl).HasColumnName(nameof(Video.EmbeddedVideoUrl)).HasColumnType("nvarchar(200)").HasMaxLength(200).IsRequired();
        builder.Property(x => x.CreatedAt).HasColumnName(nameof(Video.CreatedAt)).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.UpdatedAt).HasColumnName(nameof(Video.UpdatedAt)).HasColumnType("datetime").IsRequired(false);
    }
}
