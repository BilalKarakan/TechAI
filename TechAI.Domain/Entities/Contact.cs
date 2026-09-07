namespace TechAI.Domain.Entities;

public class Contact : BaseEntity
{
    public string PhoneNumber1 { get; set; } = default!;
    public string? PhoneNumber2 { get; set; }
    public string Email1 { get; set; } = default!;
    public string? Email2 { get; set; }
    public string Address { get; set; } = default!;
    public string Location { get; set; } = default!;
}
