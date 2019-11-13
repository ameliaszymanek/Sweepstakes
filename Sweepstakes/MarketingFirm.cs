using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //MM

        //CTOR

        //MV
        public void CreateSweepstakes(Sweepstakes sweepstakes, Contestant contestant)
        {
            sweepstakes = new Sweepstakes("");
            //choose how they want to manage sweepstakes (queue or stack)
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }

    }
}
