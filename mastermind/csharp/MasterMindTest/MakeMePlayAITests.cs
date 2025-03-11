using MasterMind;

namespace MasterMindTest
{
    public class MakeMePlayAITests
    {
        [Test]
        public void Test_HereIsMyGuess_OnASimpleCaseWithOnlyCorrectlyGuessedColors()
        {
            var solution = new Combination(Color.BLACK, Color.BLUE, Color.GREEN, Color.ORANGE);
            var guess = new Combination(Color.BLACK, Color.BLUE, Color.WHITE, Color.YELLOW);

            AssertExpectedResult(solution, guess, 2, 0);
        }

        [Test]
        public void Test_HereIsMyGuess_OnASimpleCaseWithOnlyIncorrectlyLocatedColors()
        {
            var solution = new Combination(Color.BLACK, Color.BLUE, Color.GREEN, Color.ORANGE);
            var guess = new Combination(Color.BLUE, Color.BLACK, Color.WHITE, Color.YELLOW);

            AssertExpectedResult(solution, guess, 0, 2);
        }

        [Test]
        public void Test_HereIsMyGuess_OnAComplexCaseWithDuplicatedColors()
        {
            var solution = new Combination(Color.BLACK, Color.BLUE, Color.GREEN, Color.BLACK);
            var guess = new Combination(Color.BLUE, Color.YELLOW, Color.BLUE, Color.BLACK);

            AssertExpectedResult(solution, guess, 1, 1);
        }

        [Test]
        public void Test_HereIsMyGuess_OnAnOtherComplexCaseWithDuplicatedColors()
        {
            var solution = new Combination(Color.BLACK, Color.BLUE, Color.GREEN, Color.BLACK);
            var guess = new Combination(Color.BLUE, Color.BLUE, Color.BLUE, Color.BLACK);

            AssertExpectedResult(solution, guess, 2, 0);
        }

        private void AssertExpectedResult(Combination solution, Combination guess, int expectedNbCorrect, int expectedNbCorrectAtIncorrectPosition)
        {
            var result = new MakeMePlayAI(solution).HereIsMyGuess(guess);

            Assert.That(result.NbCorrect, Is.EqualTo(2));
            Assert.That(result.NbCorrectColorAtIncorrectPosition, Is.EqualTo(0));

        }
    }
}