namespace TechAI.Domain.Entities;

public class Video : BaseEntity
{
    public string Title { get; set; } = default!;
    public string ThumbnailImageUrl { get; set; } = default!;
    public string EmbeddedVideoUrl { get; set; } = default!;
}
