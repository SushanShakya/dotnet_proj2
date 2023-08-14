using Microsoft.AspNetCore.Mvc;
using sol23.Models;
using sol23.Services.Interface;

namespace sol23.Controllers;

public class Sol23Controller : Controller
{

    IHeroService _service;

    public Sol23Controller(IHeroService service)
    {
        _service = service;
    }


    public IActionResult Index()
    {
        var heros = _service.GetAllHeros();
        ViewBag.Heros = heros;
        return View();
    }

    public IActionResult AddHero()
    {
        return View();
    }


    public IActionResult UpdateHero(int id)
    {
        var hero = _service.GetHero(id);
        return View(model: hero);
    }

    [HttpPost]
    public IActionResult DeleteHero(int id)
    {
        _service.DeleteHero(id);
        return RedirectToAction("Index", "Sol23");
    }
    [HttpPost]
    public IActionResult SaveHero(Hero hero)
    {
        _service.CreateHero(hero);
        return RedirectToAction("Index", "Sol23");
    }

    [HttpPost]
    public IActionResult Update(Hero hero)
    {
        _service.UpdateHero(hero);
        return RedirectToAction("Index", "Sol23");
    }
}