namespace Day1Test;

public class PuzzleTest
{
    [Theory]
    [InlineData("day1-example-input.txt", 142)]
    [InlineData("day1-input.txt", 52974)]
    public void GivenExampleInput_WhenRun_ReturnsExampleResult(string filename, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = Puzzle.Run(filename);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("day1-example-input-part2.txt", 281)]
    [InlineData("day1-input.txt", 53359)]
    public void GivenExampleInput_WhenRunPart2_ReturnsExampleResult(string filename, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = Puzzle.RunPart2(filename);

        // Assert
        Assert.Equal(expected, actual);
    }
}
