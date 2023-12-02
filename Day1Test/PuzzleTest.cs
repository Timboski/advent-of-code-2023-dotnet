namespace Day1Test;

public class PuzzleTest
{
    [Fact]
    public void GivenExampleInput_WhenRunProgram_ReturnsExampleResult()
    {
        // Arrange
        var filename = "day1-example-input.txt";
        var expected = 142;

        // Act
        var actual = Puzzle.Run(filename);

        // Assert
        Assert.Equal(expected, actual);
    }
}
