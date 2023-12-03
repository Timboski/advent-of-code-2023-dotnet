



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

    public int Power => FindPower();

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

    private int FindPower()
    {
        var maxRed = 0;
        var maxGreen = 0;
        var maxBlue = 0;

        foreach (var round in _rounds)
        {
            foreach ((string colour, int count) colour in round)
            {
                _ = colour.colour switch
                {
                    "red" => maxRed = Math.Max(maxRed, colour.count),
                    "green" => maxGreen = Math.Max(maxGreen, colour.count),
                    "blue" => maxBlue = Math.Max(maxBlue, colour.count),
                    _ => throw new NotImplementedException()
                };
            }
        }

        return maxRed * maxGreen * maxBlue;
    }
}
