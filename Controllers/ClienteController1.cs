using Microsoft.AspNetCore.Mvc;

namespace LojaJogos.Controllers
{
    public class ClienteController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
