namespace Shared;

public static class Targets
{
    public static void DoSomething()
    {
        Thread.Sleep(30);
    }

    public static async Task DoSomethingAsync()
    {
        await Task.Delay(30);
    }
}
