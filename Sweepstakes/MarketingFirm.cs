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
        public ISweepstakesManager manager;
        //CTOR
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        //MM
        public void CreateSweepstakes(Sweepstakes sweepstakes, Contestant contestant)
        {
            manager.InsertSweepstakes(sweepstakes);
        }

       




    }
}
