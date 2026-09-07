namespace TechAI.Domain.Entities;

public abstract class BaseEntity
{
    public string Id { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = default!;
    public DateTime? UpdatedAt { get; set; }

    protected BaseEntity()
    {
        Id = Guid.CreateVersion7().ToString();
    }
}
