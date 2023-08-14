using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace sol28.Controllers;

public class Sol28Controller : Controller
{
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
}