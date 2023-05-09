using Microsoft.AspNetCore.Mvc;
using TP04_Bottarini_Piva.Models;
namespace TP04_Bottarini_Piva.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.DicIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaCamisetas = Equipos.ListaCamisetas;
        return View();
    }

    public IActionResult GuardarIndumentaria (int Equipo, int Media, int Pantalon, int Camiseta)
    {
        Indumentaria nuevaIndumentaria = new Indumentaria(Equipos.ListaMedias[Media], Equipos.ListaPantalones[Pantalon], Equipos.ListaCamisetas[Camiseta]);
        
        Equipos.EquiposIndumentaria.Add(Equipos.ListaEquipos[Equipo], nuevaIndumentaria);

        return View("Index");
    }
}
