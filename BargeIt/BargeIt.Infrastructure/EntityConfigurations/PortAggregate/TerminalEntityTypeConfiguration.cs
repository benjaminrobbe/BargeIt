using BargeIt.Domain.AggregatesModel.PortAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.PortAggregate
{
	class TerminalEntityTypeConfiguration : IEntityTypeConfiguration<Terminal>
	{
		public void Configure(EntityTypeBuilder<Terminal> builder)
		{

			builder.HasKey(terminal => terminal.Id);

			builder.Property(terminal => terminal.Id)
				.ValueGeneratedOnAdd();

			builder.Property(terminal => terminal.Name)
				.IsRequired()
				.HasMaxLength(255);

			builder.HasMany<Quay>(terminal => terminal.Quays)
				.WithOne(quay => quay.Terminal)
				.HasForeignKey(quay => quay.TerminalId)
				.OnDelete(DeleteBehavior.Restrict);

			var storeTerminalNavigation = builder.Metadata.FindNavigation(nameof(Terminal.Quays));
			storeTerminalNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);

		}
	}
}

