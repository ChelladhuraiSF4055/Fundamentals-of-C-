using System;
using Linq;
namespace Linq;
class Program{
    public static void Main(string[] args)
    {
        string []data={"ABU DHABI","AMSTERDAM","ROME","MADURAI","LONDON","NEW DELHI","MUMBAI","NAIROBI"};
        List<string>queryResult=(from Data in  data
                                        where Data.IndexOf("M")==0 && Data.IndexOf("I")==Data.Length-1
                                        select Data).ToList();
        foreach(string city in queryResult)
        {
        System.Console.WriteLine(city);
        }
        string []data1={"ABU DHABI","AMSTERDAM","ROME","PARIS","CALIFORNIA","LONDON","NEW DELHI","ZURICH","NAIROBI"};
        List<string>queryResult2=(from Data1 in data1
                                orderby data1.Length ascending
                                select Data1).ToList();
        foreach(string city in queryResult2)
        {
            System.Console.WriteLine(city);
        }
   }
}