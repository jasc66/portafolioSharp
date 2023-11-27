using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using portafolio.Servicios;

namespace portafolio.Controllers;

public class HomeController : Controller
{
    
    private readonly IRepositorioProyectos repositoriosProyectos;
    private readonly IservicioEmail servicioEmail;

    public HomeController( IRepositorioProyectos repositoriosProyectos, IservicioEmail servicioEmail)
    {
        
        this.repositoriosProyectos = repositoriosProyectos;
        this.servicioEmail = servicioEmail;
    }

    public IActionResult Index()
    {
        
        var proyectos = repositoriosProyectos.ObtenerProyectos().Take(6).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
        return View(modelo);
    }

    public IActionResult Proyectos()
    {
        var proyectos = repositoriosProyectos.ObtenerProyectos();
        return View(proyectos);
    }
    public IActionResult Contacto()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
    {
        await servicioEmail.Enviar(contactoViewModel);
        return RedirectToAction("Gracias");
    }
    public IActionResult Gracias()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

