namespace Shared.GCode.V2;

public ref struct SpanSplitEnumerator
{
    private ReadOnlySpan<char> _remaining;
    private ReadOnlySpan<char> _current;
    private bool _isActive;
    private readonly char _splitChar;

    internal SpanSplitEnumerator(ReadOnlySpan<char> buffer, char splitChar)
    {
        _remaining = buffer;
        _current = default;
        _isActive = true;
        _splitChar = splitChar;
    }

    public ReadOnlySpan<char> Current => _current;

    public SpanSplitEnumerator GetEnumerator() => this;

    public bool MoveNext()
    {
        if (!_isActive)
        {
            return false;
        }

        int idx = _remaining.IndexOf(_splitChar);
        if (idx >= 0)
        {
            _current = _remaining[..idx];
            idx++;
            _remaining = _remaining[idx..];
        }
        else
        {
            _current = _remaining;
            _remaining = default;
            _isActive = false;
        }

        return true;
    }
}
