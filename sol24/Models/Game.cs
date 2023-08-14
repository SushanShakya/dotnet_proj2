namespace sol24.Models;

public partial class Game
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ReleaseYear { get; set; }

    public void UpdateWith(Game game)
    {
        Name = game.Name;
        ReleaseYear = game.ReleaseYear;
    }
}
