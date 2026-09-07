namespace TechAI.Domain.Entities;

public class About : BaseEntity
{
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
}
