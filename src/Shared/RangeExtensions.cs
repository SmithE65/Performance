namespace Shared;

public static class RangeExtensions
{
    public static MyEnumerator GetEnumerator(this Range range)
    {
        return new(range);
    }
}
