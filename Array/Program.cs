using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        int []sort=new int[5];
        for(int i=0;i<5;i++)
        {
            System.Console.Write($"Enter element {i}: ");
            sort[i]=Convert.ToInt32(Console.ReadLine());
        }
        //Bubble Sort
        for(int i=0;i<5;i++)
        {
            for(int j=0;j<4;j++)
            {
                if(sort[j]>sort[j+1])
                {
                    int temp=sort[j];
                    sort[j]=sort[j+1];
                    sort[j+1]=temp;
                }
            }
        }
        Console.WriteLine();
        System.Console.Write("SortedOrder: ");
        foreach(int number in sort)
        {
            System.Console.Write(number+" ");
        }
        //2.
        int []array=new int [10];
        for(int i=0;i<10;i++)
        {
            Console.WriteLine($"Enter Element {i}");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        //Displaying array
        for(int i=0;i<10;i++)
        {
            for(int j=0;j<9;j++)
            {
                if(array[j]>array[j+1])
                {
                    int temp=array[j];
                    array[j]=array[j+1];
                    array[j+1]=temp;
                }
            }
        }
        Console.WriteLine();
        System.Console.Write("SortedOrder: ");
        foreach(int number in array)
        {
            System.Console.Write(number+" ");
        }
        //Displaying even number in ascending order
        Console.WriteLine();
        System.Console.WriteLine("Displaying even number in ascending order:");
        foreach(int i in array)
        {
            if(i%2==0)
            {
                System.Console.Write(i+" ");
            }
        }
        //Descending order
        for(int i=0;i<10;i++)
        {
            for(int j=0;j<9;j++)
            {
                if(array[j]<array[j+1])
                {
                    int temp=array[j];
                    array[j]=array[j+1];
                    array[j+1]=temp;
                }
            }
        }
        Console.WriteLine();
        System.Console.WriteLine("Displaying Odd number in ascending order:");
        foreach(int i in array)
        {
            if(i%2!=0)
            {
                System.Console.Write(i+" ");
            }
        }
    }
}