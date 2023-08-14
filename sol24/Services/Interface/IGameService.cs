using sol24.Models;

namespace sol24.Services;

public interface IGameService
{
    public List<Game> GetAllGames();
    public Game GetGame(int id);

    public void CreateGame(Game game);
    public void UpdateGame(Game game);
    public void DeleteGame(int id);
}