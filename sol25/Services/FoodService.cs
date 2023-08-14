using sol25.Models;

namespace sol25.Services;

public class FoodService: IFoodService
{

    FoodContext _context;

    public FoodService(FoodContext context)
    {
        _context = context;
    }

    public void CreateMeal(Meal meal)
    {
        _context.Meals.Add(meal);
        _context.SaveChanges();
    }

    public List<Meal> GetAllMeal()
    {
        return _context.Meals.ToList();
    }

    public Meal GetMeal(int id)
    {
        return _context.Meals.First(e => e.Id == id);
    }

    public void UpdateMeal(Meal meal)
    {
        var a = _context.Meals.First(e => e.Id == meal.Id);
        if (a != null)
        {
            a.Name = meal.Name;
            _context.SaveChanges();
        }
    }

    public void DeleteMeal(int id)
    {
        var a = _context.Meals.First(e => e.Id == id);
        if (a != null)
        {
            _context.Meals.Remove(a);
            _context.SaveChanges();
        }
    }
}