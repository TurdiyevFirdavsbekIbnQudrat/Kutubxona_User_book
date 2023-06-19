namespace LoopingHomeTask.Assets;

public class AgeGenerator
{
    public uint GenerateAny() => (uint)new Random().Next(1, 200);
}