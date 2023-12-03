
namespace Day2;

public class Bag(int _numRed, int _numGreen, int _numBlue)
{
    public int NumRed => _numRed;
    public int NumGreen => _numGreen;
    public int NumBlue => _numBlue;

    public bool IsValid(string colour, int count) =>
        colour switch
        {
            "red" => count <= _numRed,
            "green" => count <= _numGreen,
            "blue" => count <= _numBlue,
            _ => throw new NotImplementedException(),
        };
}
