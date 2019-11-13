using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class ManagerFactory
    {
        public static ISweepstakesManager CreateManager()
        {
            string choice = UserInterface.GetManagerType();
            ISweepstakesManager manager = null;
            switch (choice)
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid manager type.");
                    CreateManager();
                    break;
            }
            return manager;
        }
    }
}
