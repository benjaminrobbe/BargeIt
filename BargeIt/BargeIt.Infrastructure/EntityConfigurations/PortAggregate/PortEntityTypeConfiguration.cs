using BargeIt.Domain.AggregatesModel.PortAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.PortAggregate
{
	class PortEntityTypeConfiguration : IEntityTypeConfiguration<Port>
	{
		public void Configure(EntityTypeBuilder<Port> builder)
		{

			builder.HasKey(port => port.Id);

			builder.Property(port => port.Id)
				.ValueGeneratedOnAdd();

			builder.Property(port => port.Name)
				.IsRequired()
				.HasMaxLength(255);

			builder.HasMany<Terminal>(port => port.Terminals)
				.WithOne(terminal => terminal.Port)
				.HasForeignKey(terminal => terminal.PortId)
				.OnDelete(DeleteBehavior.Restrict);

			var storePortNavigation = builder.Metadata.FindNavigation(nameof(Port.Terminals));
			storePortNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);

		}
	}
}

