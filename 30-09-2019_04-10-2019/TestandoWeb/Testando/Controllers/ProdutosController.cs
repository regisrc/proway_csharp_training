using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Testando.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}