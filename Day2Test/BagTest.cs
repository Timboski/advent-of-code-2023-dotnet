using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    [Theory]
    [InlineData("green", 13, true)]
    [InlineData("red", 13, false)]
    [InlineData("green", 14, false)]
    [InlineData("red", 12, true)]
    [InlineData("red", 1, true)]
    [InlineData("blue", 0, true)]
    [InlineData("blue", 14, true)]
    [InlineData("blue", 15, false)]
    [InlineData("blue", 255, false)]
    public void GivenNumberOfColouredCubes_WhenCheckIsValid_ReturnsWhetherCubesInBag(string colour, int count, bool expectedResult)
    {
        // Arrange
        var sut = new Bag(_numRed: 12, _numGreen: 13, _numBlue: 14);

        // Act
        var result = sut.IsValid(colour, count);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}