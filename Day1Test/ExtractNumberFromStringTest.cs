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
}