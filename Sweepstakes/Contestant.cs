using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //first name, last name, email address, registration number

        //MM
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;

        //CTOR
        public Contestant()
        {
            Contestant newContestant = new Contestant();
        }

        //MV
        public void AssignValues()
        {
            firstName = UserInterface.GetFirstName;
            lastName = UserInterface.GetLastName;
            emailAddress = UserInterface.GetEmail;
            registrationNumber = UserInterface.GetRegNumber;

            //NOW CREATE USERINTERFACE STATIC CLASS
        }
    }
}
