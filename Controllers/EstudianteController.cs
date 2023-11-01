using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tarea_12082023_jesus_soria.Models;
namespace tarea_12082023_jesus_soria.Controllers {

    public class EstudianteController : Controller {
        private readonly ILogger<EstudianteController> _logger;

        private List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public EstudianteController(ILogger<EstudianteController> logger) {
            _logger = logger;
        }


   
      
        
        // VISTA DEL FORMULARIO PARA EL ESTUDIANTE
        public IActionResult Form_estudiante() {
            return View();
        }


         // METODO POST PARA REGISTRAR EL ESTUDIANTE
        [HttpPost]
        public IActionResult Registrar(Estudiante objEstudiante) {
            string respuesta;

            try{
                 respuesta = objEstudiante.Registrar()+"";
        
            }catch(Exception ex){
                 respuesta = ex.Message;
            }
            ViewData["Message"] = respuesta;
            return View("Form_estudiante"); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View("Error!");
        }
    }
}