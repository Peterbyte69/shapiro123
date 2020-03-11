using System;
using System.IO;

namespace shapiro123
{
    class Program
    {
        static string password;
        static string username;
        static void Main(string[] args)
        {

            int intput1 = 0;
            while(intput1 == 0)
            {
                Console.WriteLine("Would you like to log in or sign up?\n1 - Log in\n2 - Sign up");
                Console.Write("\nInput - ");
                string input1 = Console.ReadLine();
                try
                {
                    intput1 = Convert.ToInt32(input1);
                }catch
                {
                    Console.WriteLine("\nYou are rather silly, that's not a number.");
                }
                if(intput1 != 1 & intput1 != 2)
                {
                    Console.WriteLine("\nPlease try agian\n");
                    intput1 = 0;
                }
                if(intput1 == 2);
                {
                    Console.WriteLine("What is your desired username?");
                       
                }
            }
        }

        static bool usernameChecker(string username)
        {
            
        }
    }
}
        

