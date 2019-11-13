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
        public void CreateSweepstakes(Sweepstakes sweepstakes, Contestant contestant, ISweepstakesManager manager)
        {
            UserInterface.GetManagerType();
            manager.InsertSweepstakes(sweepstakes);
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            manager.GetSweepstakes();
            sweepstakes.PrintContestantInfo(contestant);
        }

        

       




    }
}
