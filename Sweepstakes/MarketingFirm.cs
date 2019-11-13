using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //MV
        public ISweepstakesManager sweepstakes;
        //CTOR
        public MarketingFirm(ISweepstakesManager sweepstakes)
        {
            this.sweepstakes = sweepstakes;
        }

        //MM
        public void CreateSweepstakes(Sweepstakes sweepstakes, Contestant contestant)
        {
            sweepstakes = new Sweepstakes("");
            //choose how they want to manage sweepstakes (queue or stack)
            GetManagerType();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }

        public string GetManagerType()
        {
            Console.WriteLine("What type of data structure would you like to use to manage your sweepstakes? Your choices are 'stack' or 'queue'.");
            string input = Console.ReadLine();
            CreateManager(input);
            return input;
        }

        //public void CreateManager(string input)
        //{
        //    ISweepstakesManager managerType = null;
        //    if (input == "stack")
        //    {
        //        managerType = new SweepstakesStackManager();
        //    }
        //    else if(input == "queue")
        //    {
        //        managerType = new SweepstakesQueueManager();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a valid manager type.");
        //        GetManagerType();
        //    }
        //}
        public static ISweepstakesManager CreateManager(string managerType)
        {
            ISweepstakesManager manager = null;
            switch (managerType)
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
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
