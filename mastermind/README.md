Overview of the dojo
====================

[MasterMind](https://en.wikipedia.org/wiki/Mastermind_(board_game)) is a game in which a player has to guess a combination, receiving hints at each attempts. If you don't know that game you can refer to the wikipedia article to get more clues.

The goal of this dojo is
1. first to implement an AI that can make a human player guess a combination
2. then implement an solver that tries to guess a combination a human player is thinking about.
   (this 2nd phase can leverage code written during the first phase)
3. A possible extension is to try to write a solver that minimizes the number of guesses in order to find a solution (the best we could come up with is a solver that requires at most 5 guesses in the worst case).

Nb: in this dojo we assume that a combination is made of 4 token, and a choice of 6 color per tokens.

Overview of the provide code
============================

In order to get up to speed quickly we provide some code:

- the enum `Color` just represents all the possible colors of a given token
- the class `Combination` represent either the combination to guess, or a guess from the player. At first it is just composed of 4 colored tokens (ie: 4 `Color`). (But you will probably find it convenient to add some methods to it).
- the class `Result` represents the result of a guess. I.e. the number of token with the correct color at the correct position, and the number of correct color at an incorrect position.
- the class `MakeMePlayAI` is the class to implement during the first phase. It should make it possible for a human player to guess a combination
- the class `Solver` is the class to implement during the 2nd phase. It should guess a given combination
- `Program.cs` provides code to conveniently play against the first AI, or test the solver.

How this dojo is intended to be performed
============================================

1. The provided class `MakeMePlayAI` will make it possible for a human to guess a combination
1.1. Implement its empty constructor in order to generate a random combination (that the human player will have to guess)
1.2. Implement the method `HereIsMyGuess`, which compute the `Result` associated with a given guess. At this step you can rely on the tests in `MakeMePlayAITests`: you should turn them all to green.😉

Once this is done you can run Program.cs and try to guess the randomly generated Combination.

It is expected that this should take less than an hour, so it should be possible to complete this during the dojo.

If you have more time, you may want to continue with phase 2:

2. The goal is to come up with an algorithm that should be able to guess a given combination, and to implement it in the method `ComputeNextGuess` of the class `Solver`.
Once you implemented it you can go to `Program.cs`, comment the line `LetTheHumanPlay()`, uncomment the line `LetTheAiPlay()` instead, and launch the program.

The duration of this phase may vary greatly depending on the idea of algorithm you come up with (it's possible that you may not be able to complete it during a 1h30 dojo)

Once you are done with it, if you want more, you can try to:
- assess how much guesses your solver may require in the worst case
- try to implement a solver that requires less guesses in the worst case
(this will likely take a few more hours)

Possible solutions
==================
If you are curious, here are:

- [a simple Solver](https://codeberg.org/gturri/mastermind-solver/src/branch/main/mastermind-solver/DirectSolver.cs). It may require up to 9 guesses in the worst case.
- [a more complex Solver](https://codeberg.org/gturri/mastermind-solver/src/branch/main/mastermind-solver/MinMaxSolver.cs). The code it a bit more complex (and it's slower), but it requires at most 5 guesses in order to find a solution.
