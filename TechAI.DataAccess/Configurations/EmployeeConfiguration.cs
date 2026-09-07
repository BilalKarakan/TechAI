using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(Employee.Id)).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(x => x.Name).HasColumnName(nameof(Employee.Name)).HasColumnType("nvarchar(60)").HasMaxLength(60).IsRequired();
        builder.Property(x => x.Surname).HasColumnName(nameof(Employee.Surname)).HasColumnType("nvarchar(60)").HasMaxLength(60).IsRequired();
        builder.Property(x => x.Title).HasColumnName(nameof(Employee.Title)).HasColumnType("nvarchar(60)").HasMaxLength(60).IsRequired();
        builder.Property(x => x.ImageUrl).HasColumnName(nameof(Employee.ImageUrl)).HasColumnType("nvarchar(200)").HasMaxLength(200).IsRequired();
        builder.Property(x => x.CreatedAt).HasColumnName(nameof(Employee.CreatedAt)).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.UpdatedAt).HasColumnName(nameof(Employee.UpdatedAt)).HasColumnType("datetime").IsRequired(false);
    }
}
