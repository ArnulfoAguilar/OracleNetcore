using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OracleConnection.Interfaces;

namespace OracleConnection.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly IEstudianteServices _estudianteServices;
        public EstudianteController(IEstudianteServices estudianteServices)
        {
            _estudianteServices = estudianteServices;
        }
        public IActionResult Index()
        {
            var listaEstudiantes = _estudianteServices.ObtenerTodosEstudiantes();
            ViewData["listaEstudiantes"] = listaEstudiantes;
            return View();
        }
    }
}
