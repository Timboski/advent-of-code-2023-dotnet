using System.Collections;

namespace Day2;

public class Round : IEnumerable
{
    private readonly (string colour, int count)[] _cubes;

    public Round(string description)
    {
        _cubes = description.Split(", ").Select(ParseCube).ToArray();
    }

    public (string colour, int count) this[int i] => _cubes[i];

    public IEnumerator GetEnumerator() => _cubes.GetEnumerator();

    private (string colour, int count) ParseCube(string content)
    {
        var draw = content.Split(" ");
        return (draw[1], int.Parse(draw[0]));
    }
}
