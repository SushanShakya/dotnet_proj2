using Microsoft.AspNetCore.Mvc;
using sol24.Services;
using sol24.Models;

namespace sol24.Controllers;

public class Sol24Controller : Controller
{

    IGameService _service;

    public Sol24Controller(IGameService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var games = _service.GetAllGames();
        ViewBag.Games = games;
        return View();
    }

    public IActionResult AddGame()
    {
        return View();
    }

    public IActionResult EditGame(int id)
    {
        var game = _service.GetGame(id);
        return View(model: game);
    }


    [HttpPost]
    public IActionResult Create(Game game)
    {
        _service.CreateGame(game);
        return RedirectToAction("Index", "Sol24");
    }
    [HttpPost]
    public IActionResult Update(Game game)
    {
        _service.UpdateGame(game);
        return RedirectToAction("Index", "Sol24");
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        _service.DeleteGame(id);
        return RedirectToAction("Index", "Sol24");
    }
}