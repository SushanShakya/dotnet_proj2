using sol25.Models;

namespace sol25.Services;

public interface IFoodService
{
    public void CreateMeal(Meal meal);

    public List<Meal> GetAllMeal();

    public Meal GetMeal(int id);

    public void UpdateMeal(Meal meal);

    public void DeleteMeal(int id);
}