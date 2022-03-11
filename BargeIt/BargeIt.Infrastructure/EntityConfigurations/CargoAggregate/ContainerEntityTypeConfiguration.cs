using BargeIt.Domain.AggregatesModel.CargoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CargoAggregate
{
    class ContainerEntityTypeConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {

            builder.HasKey(container => container.Id);

            builder.Property(container => container.Id)
                .ValueGeneratedOnAdd();

            builder.Property(container => container.Type)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(container => container.Amount)
                .IsRequired();

            builder.Property(container => container.TotalWeight)
                .IsRequired();

            builder.Property(container => container.TEU)
                .IsRequired();

            builder.Property(container => container.CargoId)
                .IsRequired();

            builder.Property(container => container.Cargo)
                .IsRequired();

        }
    }
}
