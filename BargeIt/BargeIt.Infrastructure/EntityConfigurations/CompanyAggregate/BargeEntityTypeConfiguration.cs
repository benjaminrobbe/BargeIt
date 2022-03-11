using BargeIt.Domain.AggregatesModel.CompanyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CompanyAggregate
{
    class BargeEntityTypeConfiguration : IEntityTypeConfiguration<Barge>
    {
        public void Configure(EntityTypeBuilder<Barge> builder)
        {

            builder.HasKey(barge => barge.Id);

            builder.Property(barge => barge.Id)
                .ValueGeneratedOnAdd();

            builder.Property(barge => barge.IdNumber)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(barge => barge.Captain)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(barge => barge.MaxTEU)
                .IsRequired();

            builder.Property(barge => barge.PhoneNumber)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
