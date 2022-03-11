using BargeIt.Domain.AggregatesModel.PortAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.PortAggregate
{
	class QuayEntityTypeConfiguration : IEntityTypeConfiguration<Quay>
	{
		public void Configure(EntityTypeBuilder<Quay> builder)
		{

			builder.HasKey(quay => quay.Id);

			builder.Property(quay => quay.Id)
				.ValueGeneratedOnAdd();

			builder.Property(quay => quay.Number)
				.IsRequired();

			builder.Property(quay => quay.TerminalId)
				.IsRequired();

			builder.Property(quay => quay.Terminal)
				.IsRequired();

		}
	}
}

