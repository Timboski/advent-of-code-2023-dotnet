namespace Day2Test
{
    public class GameTest
    {
        [Theory]
        [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 1)]
        [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 2)]
        [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3)]
        [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 4)]
        [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 5)]
        public void GivenGameDescription_WhenCreateGame_GameHasCorrectNumber(string gameDescription, int expectedGameNumber)
        {
            // Arrange - all in InlineData

            // Act
            var sut = new Game(gameDescription);

            // Assert
            Assert.Equal(expectedGameNumber, sut.GameNumber);
        }

        [Theory]
        [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 3)]
        [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 3)]
        [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3)]
        [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 3)]
        [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 2)]
        public void GivenGameDescription_WhenCreateGame_GameHasCorrectNumberOfRounds(string gameDescription, int expectedNumberOfRounds)
        {
            // Arrange - all in InlineData

            // Act
            var sut = new Game(gameDescription);

            // Assert
            Assert.Equal(expectedNumberOfRounds, sut.NumRounds);
        }

        [Theory]
        [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 3)]
        [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 3)]
        [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3)]
        [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 3)]
        [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 2)]
        public void GivenGame_WhenFindPower_ReturnsPowerBasedOnMinCubes(string gameDescription, int expectedPower)
        {
            // Arrange
            var sut = new Game(gameDescription);

            // Act
            var power = sut.Power;

            // Assert
            Assert.Equal(expectedPower, power);
        }
    }
}
