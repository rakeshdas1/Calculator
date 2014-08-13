using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            string userChoice=Console.ReadLine();
            string exit = "Press enter to exit";
            string firstNum="Please type in your first number and press enter";
            string secondNum="Please type in your second number and press enter";
            if (userChoice == "1")
            {
                Console.WriteLine(firstNum);
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your first number is " + firstNumber);
                Console.WriteLine(secondNum);
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your second number is " + secondNumber);
                int result = firstNumber + secondNumber;
                Console.WriteLine("Your answer is " + result);
                Console.WriteLine(exit);
                Console.ReadLine();
            }
            else if (userChoice == "2")
            {
                Console.WriteLine(firstNum);
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your first number is " + firstNumber);
                Console.WriteLine(secondNum);
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your second number is " + secondNumber);
                int result = firstNumber - secondNumber;
                Console.WriteLine("Your answer is " + result);
                Console.WriteLine(exit);
                Console.ReadLine();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine(firstNum);
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your first number is " + firstNumber);
                Console.WriteLine(secondNum);
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your second number is " + secondNumber);
                int result = firstNumber * secondNumber;
                Console.WriteLine("Your answer is " + result);
                Console.WriteLine(exit);
                Console.ReadLine();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine(firstNum);
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your first number is " + firstNumber);
                Console.WriteLine(secondNum);
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your second number is " + secondNumber);
                int result = firstNumber / secondNumber;
                Console.WriteLine("Your answer is " + result);
                Console.WriteLine(exit);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have entered a unknown operator, please press enter to exit the console");
                Console.ReadLine();
                
            }
            
        }
    }
}
