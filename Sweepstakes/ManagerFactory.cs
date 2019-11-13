using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ManagerFactory
    {
        //MV

        //CTOR

        //MM
        public static ISweepstakesManager CreateManager(string managerType)
        {
            ISweepstakesManager manager = null;
            switch (managerType)
            {
                case "stack":
                    manager = new stack();
                    break;
                case "queue":
                    manager = new queue();
                    break;
                default:
                    Console.WriteLine("Not a valid manager type.");
                    CreateManager(managerType);
                    break;
            }
            return manager;
        }
    }
}
