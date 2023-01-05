using System;
namespace ExceptionHandling;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter number1: ");
        int number1=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter number2: ");
        int number2=Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine($"Divided: {number1/number2}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}