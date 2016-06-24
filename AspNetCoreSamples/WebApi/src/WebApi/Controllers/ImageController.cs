namespace WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Models;
    using Microsoft.AspNetCore.Mvc;

    [Route( "api/[controller]" )]
    public class ImageController: ApiController
    {
        private readonly IImageRepository repository;

        public ImageController( IImageRepository repository )
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Image> GetAll()
        {
            return this.repository.GetAll();
        }

        [HttpGet( "{id}" )]
        public Image GetById( int id )
        {
            return this.repository.GetById( id );
        }

        [HttpPost( "{image}" )]
        public async Task Upload( Image image )
        {
            this.repository.Add( image );
            await this.repository.UnitOfWork.CommitAsync();
        }
    }
}