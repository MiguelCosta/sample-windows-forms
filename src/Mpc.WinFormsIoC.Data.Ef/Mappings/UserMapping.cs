namespace Mpc.WinFormsIoC.Data.Ef.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Mpc.WinFormsIoC.Domain.Models;

    internal class UserMapping : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("Users");

            builder.HasKey("Id");

            builder.Property(u => u.Id)
                .HasColumnName("Id")
                .IsRequired()
                .UseSqlServerIdentityColumn();

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Password)
                .HasColumnName("Password")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Username)
                .HasColumnName("Username")
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
