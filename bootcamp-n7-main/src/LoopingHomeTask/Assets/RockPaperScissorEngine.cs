namespace LoopingHomeTask.Assets;

public class RockPaperScissorEngine
{
    private Queue<RockPaperScissorMove> _queue;


    public RockPaperScissorEngine()
    {
        _queue = new Queue<RockPaperScissorMove>();

        _queue.Enqueue(new(RockPaperScissor.Scissor, RockPaperScissor.Rock));
        _queue.Enqueue(new(RockPaperScissor.Scissor, RockPaperScissor.Paper));
        _queue.Enqueue(new(RockPaperScissor.Rock, RockPaperScissor.Paper));
        _queue.Enqueue(new(RockPaperScissor.Paper, RockPaperScissor.Scissor));
    }

    public bool HasAnyMoves() => _queue.Count > 0;

    public RockPaperScissorMove GetMove() => _queue.Dequeue();
}