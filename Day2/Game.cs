
namespace Day2;

public class Game
{
    public Game(string gameDescription)
    {
        var game = gameDescription.Split(":");
        GameNumber = int.Parse(game[0].Split(" ")[1]);
    }

    public int GameNumber { get; }
}
