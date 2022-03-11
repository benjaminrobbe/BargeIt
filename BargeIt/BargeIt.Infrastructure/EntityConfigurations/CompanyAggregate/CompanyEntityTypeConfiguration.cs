using BargeIt.Domain.AggregatesModel.CompanyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CompanyAggregate
{
    class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {

            builder.HasKey(company => company.Id);

            builder.Property(company => company.Id)
                .ValueGeneratedOnAdd();

            builder.Property(company => company.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(company => company.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(company => company.Type)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(company => company.Street)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(company => company.Number)
                .IsRequired();

            builder.Property(company => company.City)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(company => company.Postal)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(company => company.VAT)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasMany<User>(company => company.Users)
                .WithOne(user => user.Company)
                .HasForeignKey(user => user.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            var storeCompanyNavigation = builder.Metadata.FindNavigation(nameof(Company.Users));
            storeCompanyNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.HasMany<Barge>(company => company.Barges)
                .WithOne(barge => barge.Company)
                .HasForeignKey(barge => barge.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            var storePortNavigation = builder.Metadata.FindNavigation(nameof(Company.Barges));
            storePortNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
