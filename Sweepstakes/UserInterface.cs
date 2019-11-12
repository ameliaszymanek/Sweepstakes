using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        //MM


        //CTOR


        //MV
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            Console.ReadLine();
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
            return Console.ReadLine();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            Console.ReadLine();
            return Console.ReadLine();
        }

        //assign registration number???
        //public static int AssignRegNum()
        //{
        //    //logic
        //}
    }
}
