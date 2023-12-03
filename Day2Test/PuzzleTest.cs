namespace Day2Test;

public class PuzzleTest
{
    [Theory]
    [InlineData("day2-example-input.txt", 8)]
    [InlineData("day2-input.txt", 3035)]
    public void GivenExampleInput_WhenRun_ReturnsExampleResult(string filename, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = Puzzle.Run(filename);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("day2-example-input.txt", 2286)]
    [InlineData("day2-input.txt", 66027)]
    public void GivenExampleInput_WhenRunPart2_ReturnsExampleResult(string filename, int expected)
    {
        // Arrange - see inline data

        // Act
        var actual = Puzzle.RunPart2(filename);

        // Assert
        Assert.Equal(expected, actual);
    }
}
