using BargeIt.Domain.AggregatesModel.CompanyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CompanyAggregate
{
    class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Id)
                .ValueGeneratedOnAdd();

            builder.Property(user => user.FirstName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(user => user.LastName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(user => user.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(user => user.Enabled)
                .IsRequired();

            builder.Property(user => user.CompanyId)
                .IsRequired();

            builder.Property(user => user.Company)
                .IsRequired();

        }
    }
}
