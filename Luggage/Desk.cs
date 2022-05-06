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


            if (random.Next(1, 4) == 1)
            {
                desk.LuggageQueue.Enqueue(new Luggage { Id = Destination[0] + number });
            }
            else if (random.Next(1, 4) == 2)
            {
                desk.LuggageQueue.Enqueue(new Luggage { Id = Destination[1] + number });
            }
            else
            {
                luggageQueue.Enqueue(new Luggage { Id = Destination[2] + number });
            }
        }
    }
}
