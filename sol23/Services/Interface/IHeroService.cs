using sol23.Models;

namespace sol23.Services.Interface;

public interface IHeroService
{
    public Hero GetHero(int id);
    public List<Hero> GetAllHeros();
    public void UpdateHero(Hero hero);
    public void DeleteHero(int id);
    public void CreateHero(Hero hero);
}