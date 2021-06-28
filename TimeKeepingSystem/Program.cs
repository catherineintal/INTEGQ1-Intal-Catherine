
using System;
using System.Collections.Generic;

namespace TimeKeepingSystem
{
    public class UserValidation
    {

        static void Main(String[] args)
        {
            UserInformation user = new UserInformation();
            TimeStamp workTime = new TimeStamp();

            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|         Employee Time Keeping System         |");
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("Press 666 to log in");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(666))
            {
                user.LogIn();

                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("666");
            }

            Console.Write("Enter username: ");
            string userName = Console.ReadLine();

            Console.Write("Enter password: ");
            string passWord = Console.ReadLine();

            Console.WriteLine("Log in Successfully!!!");

            Console.WriteLine("======================================");

            string Date;
            Console.Write("Enter the date today:   ");
            Date = Console.ReadLine();

            string TimeIn;
            Console.Write("Enter your Time In:    ");
            TimeIn = Console.ReadLine();

            string TimeOut;
            Console.Write("Enter your Time Out:    ");
            TimeOut = Console.ReadLine();

            Console.WriteLine("======================================");

            Console.WriteLine("Date Today:  " + Date);
            Console.WriteLine("Time-In: " + TimeIn);
            Console.WriteLine("Time-Out: " + TimeOut);
            Console.WriteLine("======================================");

            Console.WriteLine("Press spacebar to continue");
            Console.ReadLine();

            ShowMenu();
        }
        static void ShowMenu()
        {
            Console.WriteLine("Type to close the Program");
            Console.WriteLine("'e' - To Exit Program");

            char menu = Convert.ToChar(Console.ReadLine());
            menu = char.ToLower(menu);

            switch (menu)
            {

                case 'e':
                    ExitProgram();
                    break;

                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }

        private static void ExitProgram()
        {
            throw new NotImplementedException();
        }
    }

}
