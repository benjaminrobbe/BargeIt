using BargeIt.Domain.AggregatesModel.CargoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CargoAggregate
{
    class ClaimEntityTypeConfiguration : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> builder)
        {

            builder.HasKey(claim => claim.Id);

            builder.Property(claim => claim.Id)
                .ValueGeneratedOnAdd();

            builder.Property(claim => claim.OfferedPrice)
                .IsRequired();

            builder.Property(claim => claim.Comment)
                .HasMaxLength(1024)
                .IsRequired();

            builder.Property(claim => claim.AcceptDate);

            builder.Property(claim => claim.DeclineDate);

            builder.Property(claim => claim.CargoId)
                .IsRequired();

            builder.Property(claim => claim.Cargo)
                .IsRequired();

            builder.HasMany<Message>(claim => claim.Messages)
                .WithOne(message => message.Claim)
                .HasForeignKey(message => message.ClaimId)
                .OnDelete(DeleteBehavior.Restrict);

            var storeClaimNavigation = builder.Metadata.FindNavigation(nameof(Claim.Messages));
            storeClaimNavigation.SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
