using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSortingSystem
{
    class LuggageSort
    {
        Desk desk1;
        Desk desk2;
        Desk desk3;
        private Queue<Luggage> luggageSortingQueue = new Queue<Luggage>();

        public LuggageSort(Desk desk1, Desk desk2, Desk desk3)
        {
            this.desk1 = desk1;
            this.desk2 = desk2;
            this.desk3 = desk3;
        }

        private static Queue<Luggage> incomingLuggage;

        public Queue<Luggage> IncomingLuggage
        {
            get { return incomingLuggage; }
            set {  incomingLuggage = value; }
        }

        public void SortLuggage()
        {
            while (true)
            {
                lock (desk1.DeskQueue)
                {
                    foreach (Luggage luggage in desk1.DeskQueue)
                    {
                        luggageSortingQueue.Enqueue(luggage);
                    //    Console.WriteLine($"Desk 1: {luggage.Id}");

                    }
                    desk1.DeskQueue.Clear();

                    foreach (Luggage luggage1 in desk1.DeskQueue)
                    {
                        Console.WriteLine(luggage1.Id);
                    }

                    foreach (Luggage luggage2 in luggageSortingQueue)
                    {
                        Console.WriteLine(luggage2.Id);
                    }
                }

                lock (desk2.DeskQueue)
                {
                    foreach (Luggage luggage in desk2.DeskQueue)
                    {
                    //    Console.WriteLine($"Desk 2: {luggage.Id}");
                    }
                }

                lock (desk3.DeskQueue)
                {
                    foreach (Luggage luggage in desk3.DeskQueue)
                    {
                    //    Console.WriteLine($"Desk 3: {luggage.Id}");
                    }
                }
            }
        }
    }
}
