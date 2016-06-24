using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Models;

namespace AspNetCoreApp.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
