using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(Contact.Id)).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(x => x.PhoneNumber1).HasColumnName(nameof(Contact.PhoneNumber1)).HasColumnType("nvarchar(11)").HasMaxLength(11).IsFixedLength(true).IsRequired();
        builder.Property(x => x.PhoneNumber2).HasColumnName(nameof(Contact.PhoneNumber2)).HasColumnType("nvarchar(11)").HasMaxLength(11).IsFixedLength(true).IsRequired(false);
        builder.Property(x => x.Email1).HasColumnName(nameof(Contact.Email1)).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Email2).HasColumnName(nameof(Contact.Email2)).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired(false);
        builder.Property(x => x.Address).HasColumnName(nameof(Contact.Address)).HasColumnType("nvarchar(400)").HasMaxLength(400).IsRequired();
        builder.Property(x => x.Location).HasColumnName(nameof(Contact.Location)).HasColumnType("nvarchar(400)").HasMaxLength(400).IsRequired(); 
        builder.Property(x => x.CreatedAt).HasColumnName(nameof(Contact.CreatedAt)).HasColumnType("datetime").IsRequired();
        builder.Property(x => x.UpdatedAt).HasColumnName(nameof(Contact.UpdatedAt)).HasColumnType("datetime").IsRequired(false);
    }
}
