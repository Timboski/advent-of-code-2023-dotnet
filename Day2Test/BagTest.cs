namespace Day2Test;

public class BagTest
{
    [Fact]
    public void GivenNumberOfEachCube_WhenCreateBag_ContainsCorrentContents()
    {
        // Arrange
        var numRed = 12;
        var numGreen = 13;
        var numBlue = 14;

        // Act
        var sut = new Bag(numRed, numGreen, numBlue);

        // Assert
        Assert.Equal(numRed, sut.NumRed);
        Assert.Equal(numGreen, sut.NumGreen);
        Assert.Equal(numBlue, sut.NumBlue);
    }
}