using Shared.GCode.V2;

namespace Shared.Tests;

public class ParserTests_V2
{
    [Theory]
    [InlineData(";comment", null, null, "comment")]
    [InlineData("G0 X1 Y0.3 Z.1;comment", "G0", 3, "comment")]
    public void Parse_Succeeds(string input, string? code, int? paramCount, string? comment)
    {
        var actual = Code.Parse(input);
        Assert.NotNull(actual);
        Assert.Equal(code, actual.GCode);
        Assert.Equal(paramCount, actual.Parameters?.Count());
        Assert.Equal(comment, actual.Comment);
    }

    [Fact]
    public void Empty()
    {
        var actual = Code.Parse(string.Empty);
        Assert.Null(actual);
    }
}

public class SpanSplitEnumeratorTests
{
    [Fact]
    public void SimpleSplit()
    {
        var sut = "start;end".AsSpan().Split(';');
        _ = sut.MoveNext();
        var first = sut.Current.ToString();
        _ = sut.MoveNext();
        var second = sut.Current.ToString();
        Assert.False(sut.MoveNext());

        Assert.Equal("start", first);
        Assert.Equal("end", second);
    }
}
