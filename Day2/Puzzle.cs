

namespace Day2;

public class Puzzle
{
    public static int Run(string filename)
    {
        var bag = new Bag(12, 13, 14);

        return File.ReadAllLines(filename)
            .Select(l => new Game(l))
            .Where(g => g.IsValid(bag))
            .Select(g => g.GameNumber)
            .Sum();
    }

    public static int RunPart2(string filename)
    {
        var bag = new Bag(12, 13, 14);

        return File.ReadAllLines(filename)
            .Select(l => new Game(l))
            .Select(g => g.Power)
            .Sum();
    }
}
