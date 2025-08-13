using CleanBookings.Domain.Users;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanBookings.Infrastructure.Configuration;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.FirstName)
            .HasMaxLength(200)
            .HasConversion(firstname => firstname.value, value => new FirstName(value));

        builder.Property(user => user.LastName)
            .HasMaxLength(200)
            .HasConversion(lastname => lastname.value, value => new LastName(value));

        builder.Property(user => user.Email)
            .HasMaxLength(200)
            .HasConversion(email => email.value, value => new Domain.Users.Email(value));

        builder.HasIndex(user => user.Email).IsUnique();
    }
}
