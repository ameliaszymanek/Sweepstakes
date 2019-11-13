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
        Random randomRegistrationNum;

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
            int winner = PickWinner();
            foreach (KeyValuePair<int, Contestant> reigstrationNumber in contestants)
            {
                if (contestant.registrationNumber == winner)
                    Console.WriteLine($"Winner's First Name: {contestant.firstName} Winner's Last Name: {contestant.lastName} Winner's Email Address: {contestant.emailAddress} Winner's Registration Number: {contestant.registrationNumber}");
            }
            return PrintContactInfo();
        }

        public int PickWinner()
        {
            //make new variable
            int winner = randomRegistrationNum.Next(1, contestants.Count);
            return winner;
            //from reference number 1 through the last reference number (how many contestants) choose a random ref num
        }
    }
}
