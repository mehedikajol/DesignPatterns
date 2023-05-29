using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        var instance11 = SingletonUnsafe.GetInstance();
        instance11.PrintMessage("Instance 01");
        var instance12 = SingletonUnsafe.GetInstance();
        instance12.PrintMessage("Instance 02");

        var instance21 = SingletonSafe.GetInstance();
        instance21.PrintMessage("Instance 01");
        var instance22 = SingletonSafe.GetInstance();
        instance22.PrintMessage("Instance 02");
    }
}