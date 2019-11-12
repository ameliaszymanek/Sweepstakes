using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //MV
        //their registration number is the key and the rest of their information is the value
        Dictionary<int, Contestant> contestants;

        //CTOR
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        //MM
        public void RegisterContestant(Contestant contestant)
        {
            //add contestant to dictionary
            contestants.Add(contestant.registrationNumber, contestant);

        }

        private void PrintContactInfo(Contestant contestant)
        {
            //
        }

        private void PickWinner()
        {
            //from reference number 1 through the last reference number (how many contestants) choose a random ref num
        }
    }
}
