namespace MasterMind
{
    public class MakeMePlayAI
    {
        private Combination _combinationToGuess;

        public MakeMePlayAI()
        {
            // Step 1.1
            // TODO: initialize a random combination that the player will have to guess
        }

        /**
         * Constructor to use for tests
         */
        public MakeMePlayAI(Combination combinationToGuess)
        {
            _combinationToGuess = combinationToGuess;
        }

        public Result HereIsMyGuess(Combination guess)
        {
            // Step 1.2
            // TODO: compute how many colors are correct / are at the correct position
            return new Result(0, 0);
        }
    }
}
