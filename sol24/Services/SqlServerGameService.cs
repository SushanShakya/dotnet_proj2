using sol24.Models;
namespace sol24.Services;

public class SqlServerGameService : IGameService
{

    Test2Context _context;

    public SqlServerGameService(Test2Context context)
    {
        _context = context;
    }

    public void CreateGame(Game game)
    {
        _context.Games.Add(game);
        _context.SaveChanges();
    }

    public void DeleteGame(int id)
    {
        var game = _context.Games.First(e => e.Id == id);
        if (game != null)
        {

            _context.Games.Remove(game);
            _context.SaveChanges();
        }
    }

    public List<Game> GetAllGames()
    {
        return _context.Games.ToList();
    }

    public Game GetGame(int id)
    {
        return _context.Games.First(e => e.Id == id);
    }

    public void UpdateGame(Game game)
    {
        var req = _context.Games.First(e => e.Id == game.Id);
        if (req != null)
        {
            req.UpdateWith(game);
            _context.SaveChanges();
        }
    }
}