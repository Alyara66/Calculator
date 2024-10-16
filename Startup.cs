﻿using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            bool isAuthorized = CheckCredentials();
            if (!isAuthorized)
            {
                Console.WriteLine("Access denied. ");
                Console.ReadKey(intercept: true);
                return;
            }
            Console.WriteLine("Console Calculator App");
            Console.ReadKey(intercept: true);
            return;

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "pow":
                    OptionsManager.Power(a, b);
                    break;
                case "log":
                    OptionsManager.Log(a, b);
                    break;
                case "fact":
                    OptionsManager.Factorial(a, b);
                case "d":
                    OptionsManager.Subtract(a, b);
                    break;
                case "sabs":
                    OptionsManager.Multiply(a, b);
                    break;
            }

            Console.WriteLine("Pres any key to close the app...");
            Console.ReadKey(true);

           
        }


    }

        private static bool CheckCredentials ()
        {
            Console.WriteLine("Enter password to gain access: ");
            string password = Console.ReadLine();
            Console.Clear();
            return password == Password;
        }
        private const string Password = "abcd1234";
     }
    

}
