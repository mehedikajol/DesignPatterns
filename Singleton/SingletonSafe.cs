namespace Singleton;

// this implementation is thread safe.
internal class SingletonSafe
{
    private static int i = 0;
    private static Lazy<SingletonSafe> Instance = new Lazy<SingletonSafe>(() => new SingletonSafe());

    private SingletonSafe()
    {
        ++i;
        Console.WriteLine("Instance created: " + i.ToString());
    }

    public static SingletonSafe GetInstance()
    {
        return Instance.Value;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
