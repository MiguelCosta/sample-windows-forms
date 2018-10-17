namespace Mpc.WinFormsIoC.Data.Ef.Mappings.Configuration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
