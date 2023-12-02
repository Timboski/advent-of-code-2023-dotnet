
namespace Day1;

public static class ExtractNumberFromString
{
    public static int ExtractCalibration(string input) => 10 * input.FindFirstNumber() + input.FindLastNumber();

    public static int FindFirstNumber(this string input) => input.First(char.IsDigit).CharToInt();

    public static int FindLastNumber(this string input) => input.Last(char.IsDigit).CharToInt();

    public static string ParseDigitText(string input) => input
            .Replace("one", "1")
            .Replace("two", "2")
            .Replace("three", "3")
            .Replace("four", "4")
            .Replace("five", "5")
            .Replace("six", "6")
            .Replace("seven", "7")
            .Replace("eight", "8")
            .Replace("nine", "9");

    private static int CharToInt(this char c) => c - '0';
}
