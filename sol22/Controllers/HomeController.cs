using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sol22.Models;
using sol22.Repositories;


namespace sol22.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private CompanyRepository _repo;

    public HomeController(ILogger<HomeController> logger, CompanyRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    public IActionResult Index()
    {
        var companies = _repo.GetCompanies();
        ViewBag.Companies = companies;
        return View();
    }

    public IActionResult AddCompany()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveCompany(Company company)
    {
        _repo.SaveCompany(company);
        return RedirectToAction("Index", "Home");
    }


    public IActionResult DeleteCompany()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        Console.WriteLine("---- INSIDE DELETE");
        Console.WriteLine(id);
        _repo.DeleteCompany(id);
        return RedirectToAction("Index", "Home");
    }

    public IActionResult UpdateCompany(int id)
    {
        var company = _repo.GetCompany(id);

        return View(model: company);
    }

    [HttpPost]
    public IActionResult Update(Company company)
    {
        _repo.UpdateCompany(company);
        return RedirectToAction("Index", "Home");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
