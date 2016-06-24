namespace WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ImagesController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}