using BaggageSortingSystem;
using System;
using System.Threading;

namespace BaggageSortingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Desk desk1 = new Desk { Destination = new string[] { "London", "Berlin", "Paris" } };
            Desk desk2 = new Desk { Destination = new string[] { "London", "Berlin", "Paris" } };
            Desk desk3 = new Desk { Destination = new string[] { "London", "Berlin", "Paris" } };
            LuggageSort luggageSort = new LuggageSort(desk1, desk2, desk3);
            LuggageGenerator luggageGenerator = new LuggageGenerator(desk1, desk2, desk3);

            Thread generateLuggage = new Thread(luggageGenerator.GenerateLuggage);
            Thread checkIn1 = new Thread(desk1.CheckIn);
            Thread checkIn2 = new Thread(desk2.CheckIn);
            Thread checkIn3 = new Thread(desk3.CheckIn);
            Thread deskCheck = new Thread(luggageSort.SortLuggage);

            generateLuggage.Start();
            checkIn1.Start();
            checkIn2.Start();
            checkIn3.Start();
            deskCheck.Start();

            generateLuggage.Join();
            checkIn1.Join();
            checkIn2.Join();
            checkIn3.Join();
            deskCheck.Join();



        }
    }
}
