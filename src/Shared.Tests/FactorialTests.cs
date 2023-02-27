namespace Shared.Tests;

public class FactorialTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(4, 24)]
    public void Linq(int number, int expected)
    {
        var result = Factorial.Linq(number);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(4, 24)]
    public void Recursive(int number, int expected)
    {
        var result = Factorial.Recursive(number);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(4, 24)]
    public void For(int number, int expected)
    {
        var result = Factorial.For(number);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(4, 24)]
    public void While(int number, int expected)
    {
        var result = Factorial.While(number);
        Assert.Equal(expected, result);
    }
}
