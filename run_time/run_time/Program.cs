// See https://aka.ms/new-console-template for more information
public class man
{
    public virtual void walk()
    {
        Console.WriteLine("I am walking using 4 legs");
    }
}
public class woman : man
{
    public override void walk()
    {
        Console.WriteLine("I am walking using 2 legs");
    }
}
class Program
{
    static void Main(string[] args)
    {
        man x = new woman();
        x.walk();
        Console.ReadLine();
    }
}
