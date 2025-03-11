using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class Solver
    {
        public Combination ComputeNextGuess(List<PlayedCombination> playedCombinations)
        {
            // TODO
            return new Combination(Color.BLACK, Color.BLACK, Color.BLACK, Color.BLACK);
        }
    }

public class PlayedCombination(Combination combination, Result result)
{
    public readonly Combination Combination = combination;
    public readonly Result Result = result;
}
}
