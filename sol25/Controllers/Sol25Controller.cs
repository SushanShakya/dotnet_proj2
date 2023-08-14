using Microsoft.AspNetCore.Mvc;

namespace sol25.Controllers;

// [Route("api/[controller]")]
// [ApiController]
// public class Sol25Controller : Controller
// {
//     IFoodService _service;

//     public Sol25Controller(IFoodService service)
//     {
//         _service = service;
//     }

//     [HttpGet]
//     public ActionResult<IEnumerable<Meal>> GetAllMeals()
//     {
//         var meals = _service.GetAllMeal();
//         return Ok(meals);
//     }

//     [HttpGet("{id}")]
//     public ActionResult<Meal> GetMeal(int id)
//     {
//         var meal = _service.GetMeal(id);
//         return Ok(meal);
//     }

//     [HttpPost("Create")]
//     public ActionResult CreateMeal(Meal meal)
//     {
//         _service.CreateMeal(meal);
//         return CreatedAtAction("Something", new { message = "Done" });
//     }

//     [HttpPut("Update")]
//     public ActionResult UpdateMeal(Meal meal)
//     {
//         _service.UpdateMeal(meal);
//         return Ok();
//     }

//     [HttpDelete("Delete/{id}")]
//     public ActionResult DeleteMeal(int id)
//     {
//         _service.DeleteMeal(id);
//         return Ok();
//     }
// }

public class Something
{
    public string? DateOfBirth { get; set; }
}


[Route("api/[controller]")]
[ApiController]
public class Sol25Controller : Controller
{
    [HttpPost("ComputeAge")]
    public ActionResult ComputeAge(Something a)
    {
        var birthDate = DateTime.Parse(a.DateOfBirth!);
        int age = DateTime.Today.Year - birthDate.Year;

        return Ok(new { age = age });
    }
}