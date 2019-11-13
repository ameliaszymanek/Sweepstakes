using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        //MV
        public static int registrationNumber = 0;

        //CTOR


        //MM
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }

        
        public static int AssignRegNum()
        {
            registrationNumber += 1;
            return registrationNumber;
        }

        

        
    }
}
