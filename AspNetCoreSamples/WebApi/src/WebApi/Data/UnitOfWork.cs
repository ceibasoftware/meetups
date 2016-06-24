namespace WebApi.Data
{
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class UnitOfWork: DbContext, IEFUnitOfWork
    {
        public UnitOfWork( DbContextOptions<UnitOfWork> options ) : 
            base( options )
        {
        }

        public DbSet<Image> Images { get; set; }

        public async Task CommitAsync()
        {
            await this.SaveChangesAsync();
        }

        public DbSet<TEntity> GetSet<TEntity>() where TEntity : Entity
        {
            return this.Set<TEntity>();
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Image>().ToTable( "Images" );

            modelBuilder.Entity<Image>()
                .HasKey( image => image.Id );

            modelBuilder.Entity<Image>()
                .Property( image => image.Name ).IsRequired().HasMaxLength( 50 );

            modelBuilder.Entity<Image>()
                .Property( image => image.Url ).IsRequired().HasMaxLength( 150 );

            modelBuilder.Entity<Image>()
                .Ignore( image => image.Data );
        }
    }
}