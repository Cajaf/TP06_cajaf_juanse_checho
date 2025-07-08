using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02_Andraca.Models;

namespace TP02_Andraca.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo.crearGrupo();
        ViewBag.Integrantes = Grupo.Integrantess;
        return View("Index");
    }
    public IActionResult SelectIntegrante(int key)
    {
        ViewBag.Nombre = Grupo.Integrantess[key].DatosPersonales.Nombre;
        ViewBag.Apellido = Grupo.Integrantess[key].DatosPersonales.Apellido;
        ViewBag.FechaNacimiento = Grupo.Integrantess[key].DatosPersonales.FechaNacimiento;
        ViewBag.Edad = Grupo.Integrantess[key].DatosPersonales.ObtenerEdad();
        ViewBag.Foto = Grupo.Integrantess[key].DatosPersonales.Foto;
        return View("infoDatosPersonales");
    }
    
    public IActionResult MostrarDatosFamiliares(int key)
    {
        ViewBag.Nombre = Grupo.Integrantess[key].DatosPersonales.Nombre;
        ViewBag.familiares = Grupo.Integrantess[key].DatosFamiliares;
        return View("infoDatosFamiliares");
    }
    public IActionResult MostrarDatosInteres(int key)
    {
        ViewBag.Nombre = Grupo.Integrantess[key].DatosPersonales.Nombre;
        ViewBag.Hobbies = Grupo.Integrantess[key].DatosIntereses.Hobbies;
        ViewBag.SeriesFavoritas = Grupo.Integrantess[key].DatosIntereses.SeriesFavoritas;
        ViewBag.GustosEscolares = Grupo.Integrantess[key].DatosIntereses.GustosEscolares;
        return View("infoDatosInteres");
    }
}
