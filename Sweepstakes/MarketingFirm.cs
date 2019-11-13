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
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }

        public string GetManagerType()
        {
            Console.WriteLine("What type of data structure would you like to use to manage your sweepstakes? Your choices are 'stack' or 'queue'.");
            string input = Console.ReadLine();
            return input;
        }

        public void ManagerTypeChoice(string managerType)
        {
            ISweepstakesManager manager = ManagerFactory.CreateManager(managerType);
            //now what?!
        }

    }
}
