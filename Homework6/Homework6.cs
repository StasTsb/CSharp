using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
            
        {
            bool accesAllowed;

            string inputdata = Console.ReadLine();
            string enterPassowrd = "qwer";

            accesAllowed = enterPassowrd == inputdata ? true : false;

            Console.WriteLine(accesAllowed);

        }
    }
}
