using Microsoft.AspNetCore.Mvc;
using sol27.Models;

namespace sol27.Controllers;

public class Sol27Controller : Controller
{
    public IActionResult Index()
    {
        return View("SignUp");
    }

    public IActionResult SignedUp()
    {
        return View();
    }

    public IActionResult SignUp(SignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Perform sign-up logic here
            // Redirect to a success page or perform other actions
        }

        return RedirectToAction("SignedUp", "Sol27");
    }
}