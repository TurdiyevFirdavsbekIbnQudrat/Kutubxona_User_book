namespace LoopingHomeTask.Assets;

public class NumberGenerator
{
    private readonly int _number;

    public NumberGenerator()
    {
        _number = new Random().Next(1, 30);
    }

    public int IsEqual(int number)
    {
        return number == _number
            ? 0
            : number < _number ? -1 : 1;
    }
}