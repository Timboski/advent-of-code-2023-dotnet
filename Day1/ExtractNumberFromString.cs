
namespace Day1;

public class ExtractNumberFromString
{
    public static int FindFirstNumber(string input) => int.Parse(input.First(char.IsDigit).ToString());

    public static int FindLastNumber(string input)
    {
        throw new NotImplementedException();
    }
}
