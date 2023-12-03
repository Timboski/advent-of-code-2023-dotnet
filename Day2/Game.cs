


namespace Day2;

public class Game
{
    private readonly List<Round> _rounds;

    public Game(string gameDescription)
    {
        var game = gameDescription.Split(": ");
        GameNumber = int.Parse(game[0].Split(" ")[1]);

        _rounds = game[1].Split("; ").Select(r => new Round(r)).ToList();
    }

    public int GameNumber { get; }
    public int NumRounds => _rounds.Count;

    public bool IsValid(Bag bag)
    {
        foreach (var round in _rounds)
        {
            foreach ((string colour, int count) colour in round)
            {
                if (!bag.IsValid(colour.colour, colour.count)) return false;
            }
        }

        return true;
    }
}
