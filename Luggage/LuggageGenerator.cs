using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaggageSortingSystem
{
    class LuggageGenerator
    {
        Desk desk1 = new Desk();
        Desk desk2 = new Desk();
        Desk desk3 = new Desk();

        private int maxQueueLength = 10;

        public LuggageGenerator(Desk desk1, Desk desk2, Desk desk3)
        {
            this.desk1 = desk1;
            this.desk2 = desk2;
            this.desk3 = desk3;
        }

        public void GenerateLuggage()
        {
            while (true)
            {
                lock (desk1.DeskQueue)
                {

                    if (desk1.DeskQueue.Count >= maxQueueLength)
                    {
                        Monitor.Wait(desk1.DeskQueue);
                    }
                    else
                    {
                        desk1.DeskQueue.Enqueue(new Luggage());

                    }
                    Monitor.PulseAll(desk1.DeskQueue);
                }

                lock (desk2.DeskQueue)
                {

                    if (desk2.DeskQueue.Count >= maxQueueLength)
                    {
                        Monitor.Wait(desk2.DeskQueue);
                    }
                    else
                    {
                        desk2.DeskQueue.Enqueue(new Luggage());

                    }
                    Monitor.PulseAll(desk2.DeskQueue);
                }

                lock (desk3.DeskQueue)
                {

                    if (desk3.DeskQueue.Count >= maxQueueLength)
                    {
                        Monitor.Wait(desk3.DeskQueue);
                    }
                    else
                    {
                        desk3.DeskQueue.Enqueue(new Luggage());

                    }
                    Monitor.PulseAll(desk3.DeskQueue);
                }
            }
        }
    }
}
