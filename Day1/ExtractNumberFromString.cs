

namespace Day1;

public static class ExtractNumberFromString
{
    public static int ExtractCalibration(string input) => 10 * input.FindFirstNumber() + input.FindLastNumber();

    public static int FindFirstNumber(this string input) => input.First(char.IsDigit).CharToInt();

    public static int FindLastNumber(this string input) => input.Last(char.IsDigit).CharToInt();

    private static int CharToInt(this char c) => c - '0';
}
