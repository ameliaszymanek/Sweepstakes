using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class ManagerFactory
    {
        public static ISweepstakesManager CreateManager(string input)
        {
            ISweepstakesManager manager = null;
            switch (input)
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid manager type.");
                    CreateManager(input);
                    break;
            }
            return manager;
        }
    }
}
