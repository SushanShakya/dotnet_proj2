using sol23.Models;
using sol23.Services.Interface;

namespace sol23.Services;

public class SqlServerHeroService : IHeroService
{

    SqlServerDbContext _context;

    public SqlServerHeroService(SqlServerDbContext context)
    {
        _context = context;
    }

    public void DeleteHero(int id)
    {
        var hero = _context.Heros!.FirstOrDefault(p => p.Id == id);
        if (hero != null)
        {
            _context.Heros!.Remove(hero);
            _context.SaveChanges();
            Console.WriteLine($"Hero {hero.Name} Removed from Db.");
        }
    }

    public List<Hero> GetAllHeros()
    {
        var heros = _context.Heros?.ToList() ?? new List<Hero>();
        foreach (var hero in heros)
        {
            Console.WriteLine(hero);
        }
        return heros;
    }

    public Hero GetHero(int id)
    {
        return _context.Heros!.First(e => e.Id == id);
    }

    public void UpdateHero(Hero hero)
    {
        var herox = _context.Heros!.FirstOrDefault(p => p.Id == hero.Id);
        if (herox != null)
        {
            herox.CopyWith(hero);
            _context.SaveChanges();
            Console.WriteLine($"Hero {hero.Name} updated successfully.");
        }
    }

    public void CreateHero(Hero hero)
    {
        _context.Heros!.Add(hero);
        _context.SaveChanges();
        Console.WriteLine($"Hero {hero.Name} added successfully.");
    }
}