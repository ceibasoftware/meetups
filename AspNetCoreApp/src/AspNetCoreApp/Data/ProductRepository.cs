using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.Data
{
    public class ProductRepository: IProductRepository
    {
        private readonly CoreContext context;

        public ProductRepository( CoreContext context )
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return this.context.Products;
        }
    }
}
