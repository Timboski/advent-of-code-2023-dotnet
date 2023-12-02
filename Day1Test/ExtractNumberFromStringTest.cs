namespace Day1Test;

public class ExtractNumberFromStringTest
{
    [Fact]
    public void GivenStringContainingNumber_WhenFindFirstNumber_ReturnsExpectedNumber()
    {
        // Arrange
        string input = "fsfd1ljkjl3er";
        int expected = 1;

        // Act
        var actual = ExtractNumberFromString.FindFirstNumber(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}