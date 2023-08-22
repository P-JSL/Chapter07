using System.Runtime.Versioning;
using static System.Console;

Doer.DoSomething();
public interface IWithStaticAbstract
{
    [RequiresPreviewFeatures]
    static abstract void DoSomething();
}

public class Doer : IWithStaticAbstract
{
    [RequiresPreviewFeatures]
    public static void DoSomething()
    {
        WriteLine("I am an implementation of a static abstract method.");
    }
}

