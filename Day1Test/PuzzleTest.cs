namespace Day1Test;

public class PuzzleTest
{
    [Theory]
    [InlineData("day1-example-input.txt", 142)]
    [InlineData("day1-input.txt", 52974)]
    public void GivenExampleInput_WhenRunProgram_ReturnsExampleResult(string filename, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = Puzzle.Run(filename);

        // Assert
        Assert.Equal(expected, actual);
    }
}
