namespace Mpc.WinFormsIoC.Data.Ef.Mappings.Configuration
{
    using Microsoft.EntityFrameworkCore;

    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration)
        where TEntity : class
        {
            configuration.Map(modelBuilder.Entity<TEntity>());
        }
    }
}
