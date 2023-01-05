using System;
namespace Strings;
class Program{
    public static void Main(string[] args)
    {
        string inputString="Syncfusion";
        for(int i=0;i<inputString.Length;i++)
        {
            if(i%2!=0)
            {
                System.Console.Write(inputString[i]);
            }
        }
        Console.WriteLine();
        System.Console.WriteLine(inputString.Replace('n','N'));
        for(int i=inputString.Length-1;i>=0;i--)
        {
            System.Console.Write(inputString[i]);
        }
        Console.WriteLine();
        System.Console.WriteLine($"Length of the String is: {inputString.Length}");
        System.Console.Write("Enter Your First String: ");
        string firstString=Console.ReadLine();
        System.Console.Write("Enter Your Second String: ");
        string secondString=Console.ReadLine();
        string concatenated=firstString.Remove(0,3)+secondString.Remove(0,2);
        System.Console.WriteLine("Output"+concatenated);
        System.Console.Write("Enter string seperated by commas:");
        string givenString=Console.ReadLine();
        string [] list=givenString.Split(",");
        int k=0;
        foreach(string word in list)
        {
            System.Console.WriteLine($"{++k}.{word}");
        }
    }
}