using MasterMind;

LetTheHumanPlay();
// LetTheAiPlay(); // Once you implemented the solver you can uncomment this line (and comment the one above instead) in order to experiment with it.


void LetTheHumanPlay()
{
    var ai = new MakeMePlayAI();
    var stillPlaying = true;

    while (stillPlaying)
    {
        var combination = ReadPlayerCombination();
        var result = ai.HereIsMyGuess(combination);
        if (result.IsASuccess())
        {
            Console.WriteLine("Congratulations!");
            stillPlaying = false;
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}


Combination ReadPlayerCombination()
{
    Console.WriteLine("What is your guess? (whitespace separated of 4 items, each in: BLACK, WHITE, GREEN, ORANGE, BLUE, YELLOW ");
    while (true)
    {
        try
        {
            string? read = null;
            while (read == null || read.Trim() == "")
            {
                read = Console.ReadLine();
            }

            var splits = read.Trim().Split(' ');
            var colors = new List<Color>();

            foreach (var split in splits)
            {
                if (!string.IsNullOrWhiteSpace(split))
                {
                   if (Enum.TryParse(split.ToUpper().Trim(), out Color color))
                   {
                       colors.Add(color);
                   } else
                   {
                       throw new Exception($"Couldn't parse ${split}");
                   }
                }
            }
            if (colors.Count != 4)
            {
                throw new Exception($"Did not read the correct number of color (expected 4, got ${colors.Count}");
            }

            return new Combination(colors[0], colors[1], colors[2], colors[3]);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Failed to read the input because {e}");
        }
    }
}

void LetTheAiPlay() {
    var stillPlaying = true;
    var playedCombinations = new List<PlayedCombination>();
    var solver = new Solver();
    while (stillPlaying)
    {
        var candidate = solver.ComputeNextGuess(playedCombinations);
        Console.WriteLine(
            $"Candidate: {candidate} (expected input: \"nbAtTheCorrectPosition nbGoodColorAtInCorrectPosition\"");
        string? read = null;
        while (read == null || read.Trim() == "")
        {
            read = Console.ReadLine();
        }

        // TODO: add some verification on the type of the input
        var splits = read.Trim().Split(' ');
        var result = new Result(nbCorrect: Convert.ToInt32(splits[0]),
            nbCorrectColorAtIncorrectPosition: Convert.ToInt32(splits[1]));

        if (result.NbCorrect == 4)
        {
            stillPlaying = false;
        }
        else
        {
            playedCombinations.Add(new PlayedCombination(candidate, result));
        }
    }

    Console.WriteLine("DONE");
}
}
