using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

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

        [HttpGet]
        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            List<string> operaciones = new List<string>();
            int resultado;
            string op;
            for (int i = 0; i < 10; i++)
            {
                
                resultado = numero * i;
                op = numero + " * " + i + " = " + resultado;

                operaciones.Add(op);
            }
            return View(operaciones);
        }

        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> resultados =
                new List<FilaTablaMultiplicar>();

            for (int i = 0; i < 10; i++)
            {
                string op = numero + " * " + i;
                int resultado = numero * i;

                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Resultado = resultado;
                fila.Operacion = op;
                resultados.Add(fila);
            }
            return View(resultados);
        }
    }

    
}
