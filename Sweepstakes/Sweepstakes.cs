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

        public void PrintContestantInfo(Contestant contestant)
        {
                Console.WriteLine($"Contestant's First Name: {contestant.firstName} Contestant's Last Name: {contestant.lastName} Contestant's Email Address: {contestant.emailAddress} Contestant's Registration Number: {contestant.registrationNumber}");
        }

        public Contestant PickWinner()
        {
            //make new variable
            int winner = randomRegistrationNum.Next(1, contestants.Count +1);
            Contestant contestant = contestants[winner];
            return contestant;
            //from reference number 1 through the last reference number (how many contestants) choose a random ref num
        }
    }
}
