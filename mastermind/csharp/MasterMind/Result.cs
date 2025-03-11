namespace MasterMind
{
    public class Result(int nbCorrect, int nbCorrectColorAtIncorrectPosition)
    {
        public bool IsASuccess() => nbCorrect == 4;
        public int NbCorrect => nbCorrect;
        public int NbCorrectColorAtIncorrectPosition => nbCorrectColorAtIncorrectPosition;

        public override string ToString()
        {
            return $"Nb correct colors at the correct location: {nbCorrect}, Nb correct colors badly located: {nbCorrectColorAtIncorrectPosition}";
        }
    }
}
