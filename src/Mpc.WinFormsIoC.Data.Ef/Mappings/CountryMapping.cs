namespace Mpc.WinFormsIoC.Data.Ef.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Mpc.WinFormsIoC.Domain.Models;

    internal class CountryMapping : IEntityTypeConfiguration<CountryModel>
    {
        public void Configure(EntityTypeBuilder<CountryModel> builder)
        {
            builder.ToTable("Countries");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(255);

            builder.Property(x => x.Alias)
                .HasColumnName("Alias")
                .HasMaxLength(255);
        }
    }
}
