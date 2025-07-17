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

    public IActionResult MostrarDatosPersonales()
    {
        string direccion = "Index";
        if(Sesion.IDUsuarioEnSesion > 0)
        {
            direccion = "infoDatosPersonales";
            DatoPersonal usuario = BD.GetUsuario(Sesion.IDUsuarioEnSesion);
            ViewBag.Usuario = usuario;
        }
        return View(direccion);
    }

    public IActionResult Deslogearse()
    {
        Sesion.IDUsuarioEnSesion = -1;
        return View("Index");
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
    public IActionResult MostrarDatosInteres()
    {
        string direccion = "Index";
        if(Sesion.IDUsuarioEnSesion > 0)
        {
            direccion = "infoDatosInteres";
            List<DatoInteres> Usuario = BD.GetDatoInteres(Sesion.IDUsuarioEnSesion);
            ViewBag.List2 = Usuario;
        }
        return View(direccion);
    }
}
