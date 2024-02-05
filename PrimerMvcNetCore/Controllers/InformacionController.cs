using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //siempre tenemos que tener un método get
        public IActionResult VistaControladorPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControladorPost
            (Persona persona, string aficiones)
        {
            ViewData["DATOS"] = "Nombre: " + persona.Nombre +
                " Email: " + persona.Email + " Edad: " + persona.Edad
                + " Aficiones: " + aficiones;
            return View();
        }

        public IActionResult ControladorVista()
        {
            //vamos a enviar info simple a la vista
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 20;
            ViewBag.DiaSemana = "Lunes";

            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Email = "model@gmail.com";
            persona.Edad = 20;

            return View(persona);
        }

        //vamos a recibir 2 params
        public IActionResult VistaControladorGet
            (string app, System.Nullable<int> version)
        {
            //ahora la version es opcional
            if(version is null)
            {

            }
            //dibujamos en la vista los parametros recibidos
            ViewData["DATOS"] = "Application: " + app.ToUpper()
                + ", Version: " + version.GetValueOrDefault();

            return View();
        }

        
       
    }
}
