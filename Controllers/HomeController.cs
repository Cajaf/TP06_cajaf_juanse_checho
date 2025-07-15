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
        return View("Index");
    }
    public IActionResult SelectIntegrante(string contraseña, string email)
    {
        string direccion = "Index";
        int num = BD.Login(contraseña, email);
        if(num != -1)
        {
            direccion = "infoDatosPersonales";
            DatoPersonal Usuario = BD.GetUsuario(num);
            ViewBag.usuario = Usuario;
            ViewBag.num = num;
            Sesion.IDUsuarioEnSesion = num;
        }
        return View(direccion);
    }  
    public IActionResult MostrarDatosFamiliares()
    {
        string direccion = "Index";
        if(Sesion.IDUsuarioEnSesion > 0)
        {
            direccion = "infoDatosFamiliares";
            List<DatoFamiliar> DatosFamiliar = BD.GetDatoFamiliar(Sesion.IDUsuarioEnSesion);
            ViewBag.List = DatosFamiliar;
        }
        return View(direccion);
    }
    public IActionResult MostrarDatosInteres(int key)
    {
        string direccion = "Index";
        if(key >= 1)
        {
            direccion = "infoDatosInteres";
            List<DatoInteres> Usuario = BD.GetDatoInteres(key);
            ViewBag.List2 = Usuario;
        }
        return View(direccion);
    }
}
