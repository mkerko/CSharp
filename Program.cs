using System;
using System.Linq;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
 {
     internal class Program
     {
         static Random _random = new Random();
         public static void Main(string[] args)
         {
             var trains = Train.RandomListOfTrains(30);
         
             var trainsToDestination = trains
                 .Where(train => train.Destination.Equals(Destination.Brest))
                 .ToList();
             Console.WriteLine("trainsToDestination");
             Train.PrintTrains(trainsToDestination);
 
             
             var start = new DateTime(1995, 1, 1);
             var range = (DateTime.Today - start).Days;           
             var dateTime = start.AddDays(_random.Next(range));
             
             Console.WriteLine("dateTime");
             Console.WriteLine(dateTime);
             
             var trainsToDestinationAndAfterTime = trains
                 .Where(train => train.Destination.Equals(Destination.Brest))
                 .Where(train => train.DepartureTime.CompareTo(dateTime) == 1)
                 .ToList();
             Console.WriteLine("trainsToDestinationAndAfterTime");
             Train.PrintTrains(trainsToDestinationAndAfterTime);
 
             var trainsToDestinationAndSameTrainType = trains
                 .Where(train => train.Destination.Equals(Destination.Brest))
                 .Where(train => train.TrainType.Equals(TrainType.General))
                 .ToList();
             Console.WriteLine("trainsToDestinationAndSameTrainType");
             Train.PrintTrains(trainsToDestinationAndSameTrainType);
         }
     }
 }