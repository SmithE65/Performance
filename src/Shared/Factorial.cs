namespace Shared;

public static class Factorial
{
    public static long Recursive(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }

        if (number < 2)
        {
            return 1;
        }

        return Recursion(number - 1);
    }

    private static long Recursion(int number) => number < 2 ? 1L : number * Recursion(number - 1);

    public static long Linq(int number) => Enumerable.Range(1, number).Aggregate(1L, (acc, number) => acc * number);

    public static long For(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }

        var result = 1L;
        for (; number > 1; number--)
        {
            result *= number;
        }

        return result;
    }

    public static long While(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }

        var result = 1L;
        while (number > 1)
        {
            result *= number;
            number--;
        }

        return result;
    }

    public static long Lookup(int number) => number switch
    {
        0 => 1L,
        1 => 1L,
        2 => 2L,
        3 => 6L,
        4 => 24L,
        5 => 120L,
        6 => 720L,
        7 => 5040L,
        8 => 40320L,
        9 => 362880L,
        10 => 3628800L,
        11 => 39916800L,
        12 => 479001600L,
        13 => 6227020800L,
        14 => 87178291200L,
        15 => 1307674368000L,
        16 => 20922789888000L,
        17 => 355687428096000L,
        18 => 6402373705728000L,
        19 => 121645100408832000L,
        20 => 2432902008176640000L,
        _ => throw new ArgumentOutOfRangeException(nameof(number)),
    };

    private static readonly long[] _bob = {
        1,
        1,
        2,
        6,
        24,
        120,
        720,
        5040,
        40320,
        362880,
        3628800,
        39916800,
        479001600,
        6227020800,
        87178291200,
        1307674368000,
        20922789888000,
        355687428096000,
        6402373705728000,
        121645100408832000,
        2432902008176640000,
    };

    public static long Array(int number) => _bob[number];
}
