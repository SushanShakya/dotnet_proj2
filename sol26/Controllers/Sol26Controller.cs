using Microsoft.AspNetCore.Mvc;
using sol26.Models;
using sol26.Services;

namespace sol26.Controllers;

public class Sol26Controller : Controller
{

    static string key = "key";

    IHttpContextAccessor _accessor;
    IStateManager _manager;

    public Sol26Controller()
    {
        _accessor = new HttpContextAccessor();
        _manager = new SessionStateManager(_accessor);
    }

    public IActionResult Index()
    {
        return View();
    }

    // Query Strings
    public IActionResult RedirectToPageWithQueryString()
    {
        return RedirectToAction("GetQueryString", "Sol26", new { id = 1 });
    }

    public IActionResult GetQueryString(int id)
    {
        return Content($"ID: {id}");
    }

    public IActionResult HiddenField()
    {
        return View();
    }

    // Hidden Field
    public IActionResult SubmitForm(int userId)
    {
        // userId is retrieved from a hidden field in the form
        return Content($"User ID: {userId}");
    }

    public IActionResult Home()
    {
        var a = _manager.GetString(key);
        var b = (string)_accessor.HttpContext!.Items[key] ?? "";
        var c = Request.Cookies[key] ?? "";
        var d = TempData[key] as string ?? "";
        var Names = new List<string> {
            $"Session State : {a}",
            $"Http Context : {b}",
            $"Cookies : {c}",
            $"TempData : {d}"
        };

        ViewBag.Names = Names;
        return View();
    }

    [HttpPost]
    public IActionResult Save(Person person)
    {

        // Saving to Session State
        _manager.SaveString(key, person.Name);

        // Saving to HTTP Context
        _accessor.HttpContext.Items[key] = person.Name;

        // Saving to Cookies
        var options = new CookieOptions();
        options.Expires = DateTime.Now.AddDays(1);
        options.Path = "/";
        Response.Cookies.Append(key, person.Name, options);

        // Saving to TempData
        TempData[key] = person.Name;

        return RedirectToAction("Home", "Sol26");
    }
}