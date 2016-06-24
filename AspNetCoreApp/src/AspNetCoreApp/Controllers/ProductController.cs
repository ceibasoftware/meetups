using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Data;
using AspNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Controllers
{
    [Route( "api/[controller]" )]
    public class ProductController: Controller
    {
        private readonly IProductRepository repository;

        public ProductController( IProductRepository repository )
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return this.repository.GetAll();
        }
    }
}
