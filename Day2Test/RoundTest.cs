namespace Day2Test;

public class RoundTest
{
    [Fact]
    public void GivenRoundInformation_WhenCreateRound_GeneratesExpectedList()
    {
        // Arrange
        var input = "8 green, 6 blue, 20 red";

        // Act
        var sut = new Round(input);

        // Assert
        Assert.Equal("green", sut[0].colour);
        Assert.Equal(8, sut[0].count);
        Assert.Equal("blue", sut[1].colour);
        Assert.Equal(6, sut[1].count);
        Assert.Equal("red", sut[2].colour);
        Assert.Equal(20, sut[2].count);
    }
}
