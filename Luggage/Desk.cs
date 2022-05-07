using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaggageSortingSystem
{
    class Desk
    {
        Random random = new Random();
        static int number = 0;
        private int maxQueueLength = 10;
        public string[] Destination { get; set; }
        private Queue<Luggage> deskQueue = new Queue<Luggage>();

       

        public Queue<Luggage> DeskQueue
        {
            get { return deskQueue;  }
            set { deskQueue = value; }
        }




        public void CheckIn()
        {
            while (true)
            {
                lock (deskQueue)
                {

                    if (deskQueue.Count <= 3)
                    {
                        Monitor.Wait(deskQueue);
                    }
                    else
                    {
                        foreach (Luggage luggage in DeskQueue)
                        {
                            if (random.Next(1, 4) == 1)
                            {
                                luggage.Id = Destination[0] + number;
                                

                            }
                            else if (random.Next(1, 4) == 2)
                            {
                                luggage.Id = Destination[1] + number;
                            }
                            else
                            {
                                luggage.Id = Destination[2] + number;
                            }
                          //  Console.WriteLine($"{luggage.Id} has been checked in.");
                            number++;
                        }
                        Monitor.PulseAll(deskQueue);

                    }
                }
            }

           
        }
    }
}
