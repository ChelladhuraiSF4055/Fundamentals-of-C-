using System;
namespace While;
class Program{
    public static void Main(string[] args)
    {
        char cont;
        do
        {
        System.Console.WriteLine("Which city is capital of India?");
        System.Console.WriteLine("1.Chennai\n2.Delhi\n3.Mumbai\n4.Kolkata");
        int answer=Convert.ToInt32(Console.ReadLine());
        if(answer==2)
        {
            System.Console.WriteLine("Correct!");
        }
        else 
        {
            System.Console.WriteLine("Incorrect!");
        }
        System.Console.Write("Press Y to continue,N to Close:");
        cont=char.Parse(Console.ReadLine().ToUpper());
        }while(cont=='Y');
    }
}