using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult SumarNumerosGet
            (int num1, int num2)
        {
            ViewData["NUM1"]  = num1;
            ViewData["NUM2"] = num2;

            int suma = num1 + num2;
            ViewData["SUMA"] = suma;
            return View();
        }

        [HttpGet]
        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost
            (int num1, int num2)
        {
            int suma = num1 + num2;
            ViewData["SUMA"] = suma;
            return View();
        }

        [HttpGet]
        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if(numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //devolvemos la lista
            return View(numeros);
        }
    }
}
