using BargeIt.Domain.AggregatesModel.CargoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BargeIt.Infrastructure.EntityConfigurations.CargoAggregate
{
    class MessageEntityTypeConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {

            builder.HasKey(message => message.Id);

            builder.Property(message => message.Id)
                .ValueGeneratedOnAdd();

            builder.Property(message => message.Content)
                .IsRequired()
                .HasMaxLength(1024);

            builder.Property(message => message.Date)
                .IsRequired();

            builder.Property(message => message.IsSystemMessage)
                .IsRequired();

            builder.Property(message => message.SenderId)
                .IsRequired();

            builder.Property(message => message.Sender)
                .IsRequired();

            builder.Property(message => message.ClaimId)
                .IsRequired();

            builder.Property(message => message.Claim)
                .IsRequired();

        }
    }
}
