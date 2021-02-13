using Microsoft.AspNetCore.Mvc;
namespace razor_fun.Controllers
{
    public class razor_funController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}