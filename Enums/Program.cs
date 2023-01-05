using System;
namespace Enums;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter number 1:");
        int number1=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter number 2: ");
        int number2=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("1.Add\n2.Subract\n3.Multiply\n4.Divide");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine($"Added: {number1+number2}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"Subract: {number1-number2}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"Mulitiplied: {number1*number2}");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"Divided: {number1/number2}");
                break;
            }
        }
    }
}