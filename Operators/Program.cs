using System;
namespace Operators;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        int number1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        int number2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Press1.Addition\n2.Subraction\n3.Mulitilication\n4.Division\n5.Modulo");
        int choice=Convert.ToInt32(Console.ReadLine());
        //Addition
        if(choice==1)
        {
            Console.WriteLine($"Added: {number1+number2}");
        }
        //Subraction
        else if(choice==2)
        {
            System.Console.WriteLine($"Subracted: {number1-number2}");
        }
        //Multiplication
        else if(choice==3)
        {
            System.Console.WriteLine($"Mulitiplied: {number1*number2}");
        }
        //Divsion
        else if(choice==4)
        {
            System.Console.WriteLine($"Divided: {number1/number2}");
        }
        //Modulo
        else if(choice==5)
        {
            System.Console.WriteLine($"Modulo: {number1%number2}");
        }
        else
        {
            System.Console.WriteLine("Out of Choice.");
        }
        //Largest of the three numbers
        System.Console.Write("Enter number1: ");
        int number3=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter number2: ");
        int number4=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter number3: ");
        int number5=Convert.ToInt32(Console.ReadLine());
        if(number3>number4)
        {
            if(number3>number5)
            {
                System.Console.WriteLine("Number1 is the largest.");
            }
        }
        else if(number4>number3)
        {
            if(number4>number5)
            {
                System.Console.WriteLine("Number2 is the  largest.");
            }
        }
        else
        {
            System.Console.WriteLine("Number3 is the largest.");
        }

    }
}