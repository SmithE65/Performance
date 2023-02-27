using System.Text;

namespace Shared.GCode.V2;

public static class CodeParseHelpers
{
    public static ReadOnlySpan<char> GetComment(ReadOnlySpan<char> line)
    {
        var index = line.IndexOf(';');

        if (index < 0)
        {
            return ReadOnlySpan<char>.Empty;
        }

        index++;

        return line[index..];
    }

    public static ReadOnlySpan<char> TrimComment(ReadOnlySpan<char> line)
    {
        var index = line.IndexOf(';');

        if (index < 0)
        {
            return line;
        }

        return line[..index];
    }
}

public static class CharSpanExtensions
{
    public static SpanSplitEnumerator Split(this ReadOnlySpan<char> span, char splitChar) => new SpanSplitEnumerator(span, splitChar);
}
