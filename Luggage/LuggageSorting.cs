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
            lock (desk1.DeskQueue)
            {
                foreach (var luggage in desk1.DeskQueue)
                {
                    Console.WriteLine($"Desk 1: {luggage.Id}");
                }
            }

            lock (desk2.DeskQueue)
            {
                foreach (var luggage in desk2.DeskQueue)
                {
                    Console.WriteLine($"Desk 2: {luggage.Id}");
                }
            }

            lock (desk3.DeskQueue)
            {
                foreach (var luggage in desk3.DeskQueue)
                {
                    Console.WriteLine($"Desk 3: {luggage.Id}");
                }
            }
        }
    }
}
