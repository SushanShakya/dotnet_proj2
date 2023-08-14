namespace sol23.Models;

public class Hero
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PowerLvl { get; set; }

    public override string ToString()
    {
        return $"Hero(id: {Id}, name: {Name}, power: {PowerLvl})";
    }

    public void CopyWith(Hero hero)
    {
        Name = hero.Name;
        PowerLvl = hero.PowerLvl;
    }
}