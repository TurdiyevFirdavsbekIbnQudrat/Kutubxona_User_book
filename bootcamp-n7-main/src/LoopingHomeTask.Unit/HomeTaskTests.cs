using FluentAssertions;
using LoopingHomeTask.Assets;
using Moq;

namespace LoopingHomeTask.Unit;

public class HomeTaskTests
{
    private readonly HomeTask _sut;
    private readonly Mock<AgeGenerator> _ageGeneratorMock;
    private readonly Mock<NumberGenerator> _numberGeneratorMock;
    private readonly Mock<RockPaperScissorEngine> _rockPaperScissorEngineMock;

    public HomeTaskTests()
    {
        _sut = new HomeTask();
        _ageGeneratorMock = new Mock<AgeGenerator>();
        _numberGeneratorMock = new Mock<NumberGenerator>();
        _rockPaperScissorEngineMock = new Mock<RockPaperScissorEngine>();
    }

    [Theory]
    [InlineData("Lorem ipsum dolor sit amet consectetur adipisicing elit  Nemo  ipsum vitae  Reiciendis neque magni laudantium laborum quas",
        "consectetur")]
    [InlineData("veniam corrupti  Voluptates a excepturi ex in  Quaerat maxime explicabo quae quisquam sequi tenetur error voluptates possimus ex",
        "Voluptates")]
    [InlineData("repudiandae omnis culpa sunt eos sint iure asperiores delectus esse nisi  odio alias modi consequatur! Porro error corrupti dolorum",
        "consequatur!")]
    public void FindMostUsedWord_WhenGivenValidWords_ShouldReturnLongestWord(string input, string expected)
    {
        // Arrange 
        var words = input.Split(',', '.', ' ');

        // Act 
        var actual = _sut.FindMostUsedWord(words);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData("Lorem ipsum dolor sit amet consectetur adipisicing elit  Nemo  ipsum vitae  Reiciendis neque magni laudantium laborum quas",
        ContentQuality.Good)]
    [InlineData("veniam corrupti  Voluptates a excepturi ex in  Quaerat maxime explicabo quae quisquam sequi tenetur error voluptates possimus ex",
        ContentQuality.Normal)]
    [InlineData("repudiandae omnis culpa sunt eos sint iure asperiores delectus esse nisi  odio alias modi consequatur! Porro error corrupti dolorum",
        ContentQuality.Good)]
    public void CalculateQualityOfText_WhenGivenValidWords_ShouldReturnContentQuality(string input, ContentQuality expected)
    {
        // Arrange
        var words = input.Split(',', '.', ' ');

        // Act 
        var actual = _sut.CalculateQualityOfText(words);

        // Assert
        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(12U)]
    [InlineData(23U)]
    [InlineData(9U)]
    public void GuessTheNumber_WhenGivanValidResult_ShouldGuessCorrectly(uint expected)
    {
        // Arrange
        var result = 0;
        _numberGeneratorMock.Setup(x => x.IsEqual(It.IsAny<int>()))
            .Callback<int>(value => result = value == expected ? 0 : value < expected ? -1 : 1)
            .Returns(() => result);

        // Act 
        var actual = _sut.GuessTheNumber(_numberGeneratorMock.Object);

        // Assert
        actual.number.Should().Be(expected);
        actual.attemptsCount.Should().Be((uint)_numberGeneratorMock.Invocations.Count);
    }

    [Theory]
    [MemberData(nameof(AgeTestCases))]
    public void GetValidAge_WhenGivenVkalidAge_ShouldReturnAge((int[] cases, int expected) testCases)
    {
        // Arrange 
        var index = 0;
        _ageGeneratorMock.Setup(x => x.GenerateAny())
            .Callback(() => index = testCases.cases.Length > index ? index++ : index)
            .Returns(() => testCases.cases[index]);

        // Act 
        var actual = _sut.GetValidAge(_ageGeneratorMock.Object);

        // Assert
        actual.Should().Be(testCases.expected);
    }

    [Theory]
    [InlineData(2, 1)]
    [InlineData(8, 21)]
    [InlineData(13, 233)]
    public void CalculateFibonacci_WhenGivenValidValue_ShouldResultValidResult(int input, int expected)
    {
        // Arrange 

        // Act 
        var actual = _sut.CalculateFibonacci(input);

        // Assert
        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(RockPaperScissorCases))]
    public void RockPaperScissorsGame_WhenGivenValidMoves_ShouldReturnValidResult((RockPaperScissorMove[] moves, Player expected) testCases)
    {
        // Arrange 
        var index = 0;
        _rockPaperScissorEngineMock.Setup(x => x.HasAnyMoves()).Returns(() => index < testCases.moves.Length);
        _rockPaperScissorEngineMock.Setup(x => x.GetMove())
            .Callback(() => index = testCases.moves.Length > index ? index++ : index)
            .Returns((() => testCases.moves[index]));

        // Act 
        var actual = _sut.GetWinner(_rockPaperScissorEngineMock.Object);

        // Assert
        actual.Should().Be(testCases.expected);
    }

    public static IEnumerable<object[]> AgeTestCases()
    {
        yield return new object[] { (new[] { 161, 172, 101 }, 101) };
        yield return new object[] { (new[] { 11, 172, 192 }, 11) };
        yield return new object[] { (new[] { 161, 31, 101 }, 31) };
    }

    public static IEnumerable<object[]> RockPaperScissorCases()
    {
        yield return new object[]
        {
            (Moves: new RockPaperScissorMove[] { new(RockPaperScissor.Scissor, RockPaperScissor.Rock), new(RockPaperScissor.Scissor, RockPaperScissor.Paper), new(RockPaperScissor.Rock, RockPaperScissor.Paper), new(RockPaperScissor.Paper, RockPaperScissor.Scissor) },
                Expected: Player.PlayerB)
        };
    }
}