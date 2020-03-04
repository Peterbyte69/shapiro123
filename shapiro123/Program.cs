using System;

namespace shapiro123
{
    class Program
    {
        static void Main(string[] args)
        {

            int intput1 = 0;
            Console.WriteLine("Would you like to log in or sign up?\n1 - Log in\n2 - Sign up");
            Console.Write("Input - ");
            string input1 = Console.ReadLine();
            try
            {
                intput1 = Convert.ToInt32(input1);
            }catch
            {
                Console.WriteLine("You are rather silly, that's not a number.");
            }
            if(intput1 == 0)
            {

            }
        }
    }
}
