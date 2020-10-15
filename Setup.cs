/*
    Calculator_Project
    Version 1.3
    Made by: Tarak Yarluv Sumod
    Purpose: Serves as a really long way of making a calculator. Could be shorter, but this is so people can use individual parts of it if they want.
    Also, it looks REALLY cool.
*/
using System;
using System.Globalization;
using System.IO.Pipes;
using System.Threading;
namespace Calculator
{
    class Color
    {
        internal static void Background()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }
        internal static void ForeGround()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
    class Input
    {
        internal static string[] Statement()
        {
            Console.WriteLine("Please enter the statement you would like to perform.\nFormat:\n'num1 operation num2'");
            var line = Console.ReadLine().ToLower();
            var data = line.Split(' ');
            return data;
        }
        internal static string Descision()
        {
            Console.WriteLine("Do you want to calculate another statement?(y/n)");
            string sDescision = Console.ReadLine().ToLower();
            return sDescision;
        }
    }

    class Operations
    {
        internal static float Addition(float num1, float num2)
        {
            float ans = num1 + num2;
            return ans;
        }
        internal static float Subtraction(float num1, float num2)
        {
            float ans = num1 - num2;
            return ans;
        }
        internal static float Multiplication(float num1, float num2)
        {
            float ans = num1 * num2; 
            return ans;
        }
        internal static float Division(float num1, float num2)
        {
            float ans = num1 / num2;
            return ans;
        }
        internal static float Pwr(float num1, float num2)
        {
            float ans = (float)Math.Pow((double)num1, (double)num2);
            return ans;
        }
    }

    class Descisions
    {
        internal static void Answer_Descision(string[] Data)
        {
            string[] operand_types = {"+", "-", "*", "/", "pwr"};
            float ans = 0f;
            int Lenth_Of_Data = Data.Length;
            bool Help = Data[0] == "help";
            if (Lenth_Of_Data == 1 && Help)
            {
                Console.WriteLine("The availible operands as of version 1.3 of the calculator are:\n1. \"+\"\n2. \"-\"\n3. \"*\"\n4. \"/\"\n5. \"pwr\"\n");
            }
            else 
            {
                float num1 = float.Parse(Data[0]);
                string operation = Data[1];
                float num2 = float.Parse(Data[2]);
                ans = Operation_Descision(num1, operation, num2);
                Output.Answer(num1, operation, num2, ans);
            }
        }
        internal static void Descision2(string sDescision)
        {
            string[] no_options = { "no", "n" };
            if (sDescision == no_options[0] || sDescision == no_options[1])
            {
                Console.WriteLine("Okay, thank you for using Tarak's calculator.\nGoodbye!\a");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
        internal static float Operation_Descision(float number1, string operation, float number2)
        {
            float ans;
            switch (operation)
            {
                case "+":
                    ans = Operations.Addition(number1, number2);
                    break;
                case "-":
                    ans = Operations.Subtraction(number1, number2);
                    break;
                case "*":
                    ans = Operations.Multiplication(number1, number2);
                    break;
                case "/":
                case "div":
                    ans = Operations.Division(number1, number2);
                    break;
                case "pwr":
                    ans = Operations.Pwr(number1, number2);
                    break;
                default:
                    ans = 0101;
                    break;
            }
            return ans;
        }
    }
    class Output
    {
        internal static void Answer(float NUM1, string OPERATION, float NUM2, float ANSWER)
        {
            if (ANSWER == 0101)
            {
                Console.WriteLine("The operator you have entered is not valid. If it is a mathematical function, please \nwait for it to be added soon");
            }
            else
            {
                Console.WriteLine($"{NUM1} {OPERATION} {NUM2} = {ANSWER}");
            }
        }
    }
}