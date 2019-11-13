using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //MM
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

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
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            emailAddress = UserInterface.GetEmailAddress();
            registrationNumber = UserInterface.AssignRegNum();
        }
    }
}
