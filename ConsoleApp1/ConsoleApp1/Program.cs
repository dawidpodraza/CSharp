using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Podaj liczbe! :");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Liczba to " + number);

        Class1 class1 = new Class1("diasd", 12);

        Console.WriteLine(class1.got());


    }
}