using Microsoft.AspNet.Mvc;

namespace MalformingDataBug.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index() => View();

        [HttpPost]
        [Route("/callback/{id?}")]
        public JsonResult CallBack(string data) =>Json(new{data2 = data});
    }
}
