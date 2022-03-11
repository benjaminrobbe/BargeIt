using BargeIt.Domain.AggregatesModel.PortAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.PortAggregate
{
	class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{

			builder.HasKey(country => country.Id);

			builder.Property(country => country.Id)
				.ValueGeneratedOnAdd();

			builder.Property(country => country.Name)
				.IsRequired()
				.HasMaxLength(255);

			builder.Property(country => country.Abbreviation)
				.IsRequired()
				.HasMaxLength(2);

			builder.HasMany<Port>(country => country.Ports)
				.WithOne(port => port.Country)
				.HasForeignKey(port => port.Id)
				.OnDelete(DeleteBehavior.Restrict);

			var storeCountryNavigation = builder.Metadata.FindNavigation(nameof(Country.Ports));
			storeCountryNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);

		}
	}
}

