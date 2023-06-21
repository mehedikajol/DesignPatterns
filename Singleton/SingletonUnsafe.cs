namespace Singleton;

// this implementation is not thread safe
// check SingletonSafe for thread safe version
internal sealed class SingletonUnsafe
{
    //private static int i = 0;
    private static SingletonUnsafe Instance = null;

    private SingletonUnsafe()
    {
        //++i;
        //Console.WriteLine("Instance created: " + i.ToString());
    }

    public static SingletonUnsafe GetInstance()
    {
        if (Instance == null)
        {
            Instance = new SingletonUnsafe();
        }
        return Instance;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
