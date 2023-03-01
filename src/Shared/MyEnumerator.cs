namespace Shared;

public ref struct MyEnumerator
{
    private int _current;
    private readonly int _end;

    public MyEnumerator(Range range)
    {
        _current = range.Start.Value;
        _end = range.End.Value;
    }

    public bool MoveNext() => _current++ < _end;
    public int Current => _current;
}