using Microsoft.AspNetCore.Mvc;

namespace DWebProjetoFinalASP.NET.Models
{
    public class Produtos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
