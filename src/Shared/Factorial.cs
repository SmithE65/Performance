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

        return number * Recursive(number - 1);
    }

    public static long Linq(int number) => Enumerable.Range(1, number).Aggregate(1L, (acc, number) => acc * number);

    public static long For(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }

        var result = 1L;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
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
        0 => 1,
        1 => 1,
        2 => 2,
        3 => 6,
        4 => 24,
        5 => 120,
        6 => 720,
        7 => 5040,
        8 => 40320,
        9 => 362880,
        10 => 3628800,
        11 => 39916800,
        12 => 479001600,
        13 => 6227020800,
        14 => 87178291200,
        15 => 1307674368000,
        16 => 20922789888000,
        17 => 355687428096000,
        18 => 6402373705728000,
        19 => 121645100408832000,
        20 => 2432902008176640000,
        _ => throw new ArgumentOutOfRangeException(nameof(number)),
    };
}
