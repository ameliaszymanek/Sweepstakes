using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //MV
        public static int registrationNumber = 0;

        //CTOR


        //MM
        public static string GetManagerType()
        {
            Console.WriteLine("What type of data structure would you like to use to manage your sweepstakes? Your choices are 'stack' or 'queue'.");
            string input = Console.ReadLine();
            return input;
        }
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
