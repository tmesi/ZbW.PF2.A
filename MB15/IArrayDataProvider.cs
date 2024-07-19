namespace MB15
{
    public interface IArrayDataProvider {
        int MinValue { get; }
        int AvgValue { get; }
        int RandomValue { get; }
        int MaxValue { get; }
        int NotFoundValue { get; }
        int[] Data { get; }
    }
}
