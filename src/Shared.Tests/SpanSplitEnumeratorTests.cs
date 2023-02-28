namespace Shared.Tests;

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
