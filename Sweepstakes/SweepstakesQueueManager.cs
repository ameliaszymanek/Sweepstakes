using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        //MV
        Queue<Sweepstakes> queue;

        //CTOR
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //MM
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
