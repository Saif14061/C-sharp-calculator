using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("welcome to the calulator program made by Saif Abbas");

        Console.WriteLine("enter in the first number: ");
        double num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter in the second number: ");
        double num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("what type of mathematical operations");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                Console.WriteLine("the answer is = " + (num1 + num2));
                break;
            case "2":
                Console.WriteLine("the answer is = " + (num1 - num2));
                break;
            case "3":
                Console.WriteLine("the answer is = " + (num1 * num2));
                break;
            case "4":
                Console.WriteLine("the answer is = " + (num1 / num2));
                break;
            default:
                Console.WriteLine("this is not a valid operation!!");
                break;


        }
       


        Console.ReadKey();
    }
}

