﻿using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "pow - Power",
            "log - Logaritm",
            "fact - Sum of 2 factorial"
            "d - DIvide",
            "sabs - Substract Abs",

        };

        public static void Power(double a, double b)
        {
            Console.WriteLine( $"{a} ^ {b} = {Math.Pow(a,b)}");
        }
        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a} with base {b} = {Math.Log(a, b)}");
        }
        public static void Factorial(double a, double b)
        {
            long factA = CalculateFact((int)a);
            long factB = CalculateFact((int)b);
            Console.WriteLine($"{a}! + {b}! = {(int)a}!+ {(int)b}!= {factA + factB}");

        }
        private static long CalculateFact(int a)
        {
            long result = a;
            for (int i = a-1; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }
        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Divide(double a, double b) 
        {
            Console.WriteLine($"|{a} : {b}| = {a/b}");
        }
        public static void SubstractAbs(double a, double b)
        {
            Console.WriteLine($"|{a} - {b}| = {Math.Abs(a - b)}");
        }
    }
}
