
namespace Day1;

public static class ExtractNumberFromString
{
    public static int FindFirstNumber(this string input) => int.Parse(input.First(char.IsDigit).ToString());

    public static int FindLastNumber(string input) => int.Parse(input.Last(char.IsDigit).ToString());
}
