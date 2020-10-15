using Calculator;
using System;

class Program
{
    private static void Main()
    {
        Color.Background();
        Color.ForeGround();
        Console.Title = "Calculator Project Version 1.3";
        Console.WriteLine("Calculator_Project\nVersion 1.3\nMade by: Tarak Yarluv Sumod.\nPurpose: Serves as a really long way of making a calculator.Could be shorter, \nbut this is so people can use individual parts of it if they want.\nAlso, it looks REALLY cool.\nFor help, type \"help\"");
        while (true)
        {
            var data = Input.Statement();
            Descisions.Answer_Descision(data);
            string cDescision = Input.Descision();
            Descisions.Descision2(cDescision);
        }
    }
}
