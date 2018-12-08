using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Train
    {
        private const int _maxTrainNumber = 100;

        public Destination Destination { get; set; }

        public int Number { get; set; }

        public DateTime DepartureTime { get; set; }

        public TrainType TrainType { get; set; }

        private static readonly Random Random = new Random();

        private Train() {
        }

        private static Train CreateRandomTrain(){
            var trainTypes = Enum.GetValues(typeof(TrainType));
            var randomTrainType= (TrainType)trainTypes.GetValue(Random.Next(trainTypes.Length));
            
            var destinations = Enum.GetValues(typeof(Destination));
            var randomDestination= (Destination)destinations.GetValue(Random.Next(trainTypes.Length));

            var train = new Train
            {
                Destination = randomDestination,
                Number = Random.Next(_maxTrainNumber),
                DepartureTime = RandomTimeStamp(),
                TrainType = randomTrainType
            };
            return train;
        }
    
        private static DateTime RandomTimeStamp(){
            var start = new DateTime(1995, 1, 1);
            var range = (DateTime.Today - start).Days;           
            return start.AddDays(Random.Next(range));
        }
    
        public static List<Train> RandomListOfTrains(int amount){
            var trains = new List<Train>();
            for (var i = 0; i < amount; i++){
                trains.Add(CreateRandomTrain());
            }
            return trains;
        }
    
        public static void PrintTrains(List<Train> trains){
            trains.ForEach(train => Console.WriteLine(train.ToString()));
        }
    
        public override string ToString()
        {
            return string.Format("Destination: {0}, Number: {1}, DepartureTime: {2}, TrainType: {3}", Destination, Number, DepartureTime, TrainType);
        }
        
    }
}