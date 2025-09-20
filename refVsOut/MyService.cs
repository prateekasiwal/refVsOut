namespace refVsOut;

public interface IMyService
{
    void MyName(string name);
}

public class MyService : IMyService
{
    public void MyName(string name)
    {
        Console.WriteLine($"My Name is {name}");
    }
}

