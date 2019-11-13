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
            UserInterface.GetManagerType();
            //based on what type of manager user chooses a new sweepstakes will be created
            //call the 2 functions that are in the ISweepstakesManager Interface

            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }

        

       




    }
}
