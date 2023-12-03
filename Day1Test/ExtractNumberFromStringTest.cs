namespace Day1Test;

public class ExtractNumberFromStringTest
{
    [Theory]
    [InlineData("fsfd1ljkjl3er", 1)]
    [InlineData("1abc2", 1)]
    [InlineData("pqr3stu8vwx", 3)]
    [InlineData("a1b2c3d4e5f", 1)]
    [InlineData("treb7uchet", 7)]
    public void GivenStringContainingNumber_WhenFindFirstNumber_ReturnsExpectedNumber(string input, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = ExtractNumberFromString.FindFirstNumber(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("fsfd1ljkjl3er", 13)]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void GivenStringContainingNumber_WhenExtractCalibration_ReturnsExpectedNumber(string input, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = ExtractNumberFromString.ExtractCalibration(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("two1nine", 2)]
    [InlineData("eightwothree", 8)]
    [InlineData("abcone2threexyz", 1)]
    [InlineData("xtwone3four", 2)]
    [InlineData("4nineeightseven2", 4)]
    [InlineData("zoneight234", 1)]
    [InlineData("7pqrstsixteen", 7)]
    public void GivenStringContainingNumber_WhenFindFirstNumberOrText_ReturnsExpectedNumber(string input, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = ExtractNumberFromString.FindFirstNumberOrText(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("two1nine", 9)]
    [InlineData("eightwothree", 3)]
    [InlineData("abcone2threexyz", 3)]
    [InlineData("xtwone3four", 4)]
    [InlineData("4nineeightseven2", 2)]
    [InlineData("zoneight234", 4)]
    [InlineData("7pqrstsixteen", 6)]
    [InlineData("six7pqrstsixteen", 6)]
    public void GivenStringContainingNumber_WhenFindLastNumberOrText_ReturnsExpectedNumber(string input, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = ExtractNumberFromString.FindFLastNumberOrText(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    public void GivenStringContainingNumber_WhenExtractCalibrationWithText_ReturnsExpectedNumber(string input, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = ExtractNumberFromString.ExtractCalibrationWithText(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
