using System.Text;

namespace Shared;

public static class SampleData
{
    private static string[]? _gcodeLines = null;

    public static string[] GCodeSamples => LoadGcode();

    private static string[] LoadGcode()
    {
        if (_gcodeLines != null)
        {
            return _gcodeLines;
        }

        var lineEnumerator = Resource1.GCodeSample1.AsSpan().EnumerateLines();

        var lines = 0L;
        while (lineEnumerator.MoveNext())
        {
            lines++;
        }

        _gcodeLines = new string[lines];
        lineEnumerator = Resource1.GCodeSample1.AsSpan().EnumerateLines();
        for (long i = 0; i < lines && lineEnumerator.MoveNext(); i++)
        {
            _gcodeLines[i] = lineEnumerator.Current.ToString();
        }

        return _gcodeLines;
    }
}
