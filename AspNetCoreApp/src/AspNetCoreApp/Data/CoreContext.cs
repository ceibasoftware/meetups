using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApp.Data
{
    public class CoreContext: DbContext
    {
        public CoreContext( DbContextOptions<CoreContext> options ): base( options )
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            builder.Entity<Product>().HasKey( product => product.Id );
            builder.Entity<Product>().Property( product => product.Name ).IsRequired().HasMaxLength( 100 );
            builder.Entity<Product>().Property( product => product.Price ).IsRequired();
        }
    }
}
