using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.WriteLine("Enter Menu Number");
            int option = Convert.ToInt32(Console.ReadLine());
            TraineeDetails obj = new TraineeDetails();
            TraineeData ob1 = new TraineeData();
            List<TraineeDetails> b = ob1.GetTraineeDetails();
            
            //List<TraineeDetails>queryselector=new List<TraineeDetails>();
            switch(option)
            {
                case 1:
                    {
                        List<TraineeDetails>queryselector=(from data in b
                                                        select data).ToList();
                        System.Console.WriteLine("Trainee ID");
                        foreach(TraineeDetails trainne in queryselector)
                        {
                            Console.WriteLine($"{trainne.TraineeId}");
                        }
                        break;
                    }
                case 2:
                    {
                        IEnumerable<string>queryselector= (from data in b 
                                                            select data.TraineeId).Take(3);
                        System.Console.WriteLine("First three trainne ID:");
                        foreach(string trainee in queryselector)
                        {
                            System.Console.WriteLine(trainee);
                        }
                        break;
                    }
                case 3:
                    {
                        List<TraineeDetails>queryselector=(from data in b
                                                           // where b.Count-1-b.IndexOf(data)<=2
                                                            select data).Skip(b.Count-2).ToList();
                        System.Console.WriteLine("Last 2 Trainee ID:");
                        foreach(TraineeDetails trainee in queryselector)
                        {
                            System.Console.WriteLine(trainee.TraineeId);
                        }
                        break;
                    }
                case 4:
                {
                    int queryselector=(from data in b
                                    select b).Count();
                    System.Console.WriteLine($"No Of Trainee:{queryselector}");
                    break;
                }
                case 5:
                {
                    List<TraineeDetails>queryselector=(from data in b
                                                        where data.YearPassedOut>=2019
                                                        select data).ToList();
                    System.Console.WriteLine("Trainee who are all passed out of 2019and later:");
                    foreach(TraineeDetails trainee in queryselector)
                    {
                        System.Console.WriteLine(trainee.TraineeName);
                    }
                    break;
                }
                case 6:
                {
                    List<TraineeDetails>queryselector=(from data in b
                                                        orderby data  ascending
                                                        select data).ToList();
                    System.Console.WriteLine("Trainee Name in alphabetical order:");
                    foreach(TraineeDetails trainee in queryselector)
                    {
                        System.Console.WriteLine(trainee.TraineeName);
                    }
                    break;
                }
                /*case 7:
                {
                    List<TraineeScore>queryselector=(from data in b
                                                        where data.Mark>=4
                                                        select data).ToList();
                    System.Console.WriteLine("Trainees who scored more than 4 marks");
                    
                    foreach(TraineeScore score in )
                }*/
                case 8:
                {
                    List<int>queryselector=(from data in b
                                                        select data.YearPassedOut).Distinct().ToList();
                    System.Console.WriteLine("Distinct PassedOut Years: ");
                    foreach(int trainee in queryselector)
                    {
                        System.Console.WriteLine(trainee);
                    }
                    break;
                }
                case 9:
                {
                    Console.Write("Enter Your TraineeID: ");
                    string traineeID=Console.ReadLine();
                    IEnumerable<int>queryselector=(from data in b
                                        where data.TraineeId==traineeID
                                        select data.TotalScore);
                    if(queryselector.Count()==0)
                    {
                        System.Console.WriteLine("Invalid Trainee ID.");
                    }
                    else
                    {
                        foreach(int mark in queryselector)
                        {
                            System.Console.WriteLine(queryselector);
                        }
                    }
                    break;
                }
                case 10:
                {
                        TraineeDetails trainee= b.First(); 
                        System.Console.WriteLine($"Trainee ID:{trainee.TraineeId} TraineeName: {trainee.TraineeName}");
                                                            break;                                                                                
                }
                case 11:
                {
                    TraineeDetails trainee=b.Last();
                    System.Console.WriteLine($"Last Trainee ID:{trainee.TraineeId}\nLast Trainee Name: {trainee.TraineeName}");
                    break;
                }
                case 12:
                {
                    List<TraineeDetails>queryselector=(from data in b
                                                        select data).ToList();
                    foreach(TraineeDetails trainee in queryselector)
                    {
                        System.Console.WriteLine($"Trainee Name: {trainee.TraineeName} Total Score: {trainee.TotalScore}");
                    }
                    break;
                }
                case 13:
                {
                    int MaxScore=(from data in b 
                                    select data.TotalScore).Max();
                    System.Console.WriteLine($"Maximum Score recorded: {MaxScore}");
                    break;
                }
                case 14:
                {
                    int MinScore=(from data in b
                                    select data.TotalScore).Min();
                    System.Console.WriteLine($"Minimum Score recorded: {MinScore}");
                    break;
                }
                case 15:
                {
                    double Average=(from data in b
                                select data.TotalScore).Average();
                    System.Console.WriteLine($"Average of all scores:{Average}");
                    break;

                }
                case 16:
                {
                    bool result=(from data in b
                                where data.TotalScore>40
                                select data).Any();
                    System.Console.WriteLine(result);
                                break;
                }
                case 17:
                {
                    bool result =(from data in b 
                                select data).All(data=>data.TotalScore>20);
                                System.Console.WriteLine(result);
                                break;
                }
                case 18:
                {
                    IEnumerable<TraineeDetails>queryselector=(from data in b
                                                            orderby data  descending
                                                            select data);
                    foreach(TraineeDetails trainee in queryselector)
                    {
                        System.Console.WriteLine($"TraineeID: {trainee.TraineeId} Trainee Name: {trainee.TraineeName} ");
                    }
                    break;
                }

             
            }
           
        }
    }
}
