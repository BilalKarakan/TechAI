namespace TechAI.Domain.Entities;

public class Blog : BaseEntity
{
    public string Title { get; set; } = default!;
    public string CoverImageUrl { get; set; } = default!;
    public string MainImageUrl { get; set; } = default!;
    public string Content { get; set; } = default!;
}
