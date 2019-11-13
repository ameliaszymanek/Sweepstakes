using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface ISweepstakesManager
    {
        //MM
        void InsertSweepstakes(Sweepstakes sweepstakes);
        void GetSweepstakes(Sweepstakes sweepstakes);

    }
}
