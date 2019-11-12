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
            firstName = null;
            lastName = null;
            emailAddress = null;
            registrationNumber = 0;
        }

        //MV
        public void AssignValues()
        {
            firstName = UserInterface.GetFirstName;
            lastName = UserInterface.GetLastName;
            emailAddress = UserInterface.GetEmail;
            registrationNumber = UserInterface.GetRegNumber;

            //figure out how to talk to static class
            //figure out where to assign a registration number
        }
    }
}
