using LoopingHomeTask.Assets;

namespace LoopingHomeTask;

public enum ContentQuality
{
    Low,
    Normal,
    Good
}

public enum RockPaperScissor
{
    Rock,
    Paper,
    Scissor
}

public enum Player
{
    PlayerA,
    PlayerB
}

public class RockPaperScissorMove
{
    public RockPaperScissorMove(RockPaperScissor playerA, RockPaperScissor playerB)
    {
        PlayerA = playerA;
        PlayerB = playerB;
    }

    public RockPaperScissor PlayerA { get; set; }
    public RockPaperScissor PlayerB { get; set; }
}

public class HomeTask
{
    #region Processing Collections

    // Task A 
    // Process collection to find the longest word and return it
    public string FindMostUsedWord(IEnumerable<string> words)
    {
        throw new NotImplementedException();
    }

    // Task B 
    // Calculate text quality by formulas : 
    // x word occurence > words count / 4 - decrement quality counter
    // number of words longer than 10 chars > 4 - increment quality counter
    // quality counter - less than 0 - low, 0 - normal, greater than 1 - good
    public ContentQuality CalculateQualityOfText(IEnumerable<string> words)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Indefinite Operations

    // Task C
    // NumberGenerator generates a random number ( between 1 and 30 )
    // Guess that number until guess is correct
    // IsEqual - returns -1 - if guess is less, 0 - equal, 1 - greater than the actual value
    public (uint number, uint attemptsCount) GuessTheNumber(NumberGenerator generator)
    {
        // Example to check if guess is correct
        var result = generator.IsEqual(10);

        throw new NotImplementedException();
    }

    // Task D 
    // AgeGenerator generates an age value randomly and sometimes invalid values ( between 1 and 200 )
    // Generate age value until valid age is generated which should be less than 150
    public int GetValidAge(AgeGenerator generator)
    {
        // Example to generate an age
        var age = generator.GenerateAny();

        throw new NotImplementedException();
    }

    #endregion

    #region Iterative Processing

    // Task E : 
    // Calculate fibonacci value for given number
    public int CalculateFibonacci(int value)
    {
        throw new NotImplementedException();
    }

    // Task F : 
    // RockPaperScissorEngine - engine for popular game rock - paper - scissor
    // Calculate the winner based on the moves given by the engine
    // Stop calculation and return the result when either of players reaches score 3
    // HasAnyMoves - returns true if any moves left unprocessed
    // GetMove - retrieves moves one by one
    public Player GetWinner(RockPaperScissorEngine engine)
    {
        // Example to check if there is any move
        var hasMove = engine.HasAnyMoves();
        // Retrieve the move
        var move = engine.GetMove();

        throw new NotImplementedException();
    }

    #endregion
}