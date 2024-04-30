using Microsoft.AspNetCore.Mvc;

namespace DWebProjetoFinalASP.NET.Models
{
    public class CarrinhoCompras : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
