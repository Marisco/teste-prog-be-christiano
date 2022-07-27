using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JogoDaVelhaWebApi.Controllers
{
    public class BaseController : Controller
    {
        protected static IActionResult ResponderJsonResult(object viewModel, NullValueHandling nullValueHandling = NullValueHandling.Include)
        {
            return new JsonResult(viewModel);
        }
    }
}
