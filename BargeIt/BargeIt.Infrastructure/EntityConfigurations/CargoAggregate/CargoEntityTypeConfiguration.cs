using BargeIt.Domain.AggregatesModel.CargoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CargoAggregate
{
    public class CargoEntityTypeConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.HasKey(cargo => cargo.Id);

            builder.Property(cargo => cargo.Id)
                .ValueGeneratedOnAdd();

            builder.Property(cargo => cargo.CargoIdNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(cargo => cargo.CompanyId)
                .IsRequired();

            builder.Property(cargo => cargo.Company)
                .IsRequired();

            builder.HasOne(cargo => cargo.TerminalOrigin)
                .WithMany()
                .HasForeignKey(terminal => terminal.TerminalOrigin)
                .IsRequired();

            builder.HasOne(cargo => cargo.TerminalDestination)
                .WithMany()
                .HasForeignKey(terminal => terminal.Id)
                .IsRequired();

            builder.HasOne(cargo => cargo.QuayOrigin)
                .WithMany()
                .HasForeignKey(quay => quay.Id);

            builder.HasOne(cargo => cargo.QuayDestination)
                .WithMany()
                .HasForeignKey(quay => quay.Id);

            builder.Property(cargo => cargo.CreditsCost)
                .IsRequired();

            builder.Property(cargo => cargo.RequestedPrice)
                .IsRequired();

            builder.Property(cargo => cargo.IsFixedPrice)
                .IsRequired();

            builder.Property(cargo => cargo.PickUpDateStart)
                .IsRequired(); ;

            builder.Property(cargo => cargo.PickUpDateEnd)
                .IsRequired();

            builder.Property(cargo => cargo.PickUpIsFullDay)
                .IsRequired();

            builder.Property(cargo => cargo.DropOffDateStart)
                .IsRequired();

            builder.Property(cargo => cargo.DropOffDateEnd)
                .IsRequired();

            builder.Property(cargo => cargo.DropOffIsFullDay)
                .IsRequired();

            builder.Property(cargo => cargo.HasDangerousGoods)
                .IsRequired();

            builder.Property(cargo => cargo.Status)
                .IsRequired();

            builder.HasMany(cargo => cargo.Claims)
                .WithOne(claim => claim.Cargo)
                .HasForeignKey(claim => claim.CargoId);

            var storeCargoNavigation = builder.Metadata.FindNavigation(nameof(Cargo.Claims));
            storeCargoNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
