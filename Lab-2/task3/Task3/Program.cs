using System;
using System.Threading;
using System.Threading.Tasks;

public sealed class Authenticator
{
    private static readonly Lazy<Authenticator> _instance =
        new Lazy<Authenticator>(() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);
    private Authenticator()
    {
        Console.WriteLine("Authenticator instance created.");
    }
    public static Authenticator Instance => _instance.Value;

    public void Authenticate(string username, string password)
    {
        Console.WriteLine($"Authenticating {username}...");
    }
}

class Program
{
    static void Main()
    {
        Parallel.Invoke(
            () => { var auth1 = Authenticator.Instance; auth1.Authenticate("User1", "pass1"); },
            () => { var auth2 = Authenticator.Instance; auth2.Authenticate("User2", "pass2"); },
            () => { var auth3 = Authenticator.Instance; auth3.Authenticate("User3", "pass3"); }
        );

        Console.WriteLine("All authentications completed.");
    }
}