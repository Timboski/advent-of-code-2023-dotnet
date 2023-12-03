



namespace Day1;

public static class ExtractNumberFromString
{
    private record Digit(string Name, int Value);

    private readonly static Digit[] Digits = [
        new("one", 1),
        new("1", 1),
        new("two", 2),
        new("2", 2),
        new("three", 3),
        new("3", 3),
        new("four", 4),
        new("4", 4),
        new("five", 5),
        new("5", 5),
        new("six", 6),
        new("6", 6),
        new("seven", 7),
        new("7", 7),
        new("eight", 8),
        new("8", 8),
        new("nine", 9),
        new("9", 9)
        ];

    public static int ExtractCalibration(string input) => 10 * input.FindFirstNumber() + input.FindLastNumber();

    public static int ExtractCalibrationWithText(string input) => 10 * input.FindFirstNumberOrText() + input.FindFLastNumberOrText();

    public static int FindFirstNumber(this string input) => input.First(char.IsDigit).CharToInt();

    public static int FindFirstNumberOrText(this string input)
    {
        var minIndex = int.MaxValue;
        var firstDigit = -1;
        foreach (var digit in Digits)
        {
            int index = input.IndexOf(digit.Name);
            if (index >= 0 && index < minIndex)
            {
                minIndex = index;
                firstDigit = digit.Value;
            }
        }

        return firstDigit;
    }

    public static int FindLastNumber(this string input) => input.Last(char.IsDigit).CharToInt();

    public static int FindFLastNumberOrText(this string input)
    {
        var maxIndex = -1;
        var lastDigit = -1;
        foreach (var digit in Digits)
        {
            int index = input.LastIndexOf(digit.Name);
            if (index > maxIndex)
            {
                maxIndex = index;
                lastDigit = digit.Value;
            }
        }

        return lastDigit;
    }

    private static int CharToInt(this char c) => c - '0';
}
