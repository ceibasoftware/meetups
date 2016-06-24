namespace WebApi.Data
{
    using Models;

    public class ImageRepository: Repository<Image>, IImageRepository
    {
        public ImageRepository( UnitOfWork unitOfWork ) 
            : base( unitOfWork )
        {
        }
    }
}