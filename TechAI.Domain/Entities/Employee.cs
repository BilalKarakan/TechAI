namespace TechAI.Domain.Entities;

public class Employee : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
}
