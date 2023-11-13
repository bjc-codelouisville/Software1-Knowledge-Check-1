using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add"); //original line
                    var (addNumber1, addNumber2) = ValidateIntegers(); //run our new method
                    var (addNumOne, addNumTwo) = (addNumber1, addNumber2); // extra line so we don't have to modify original variables

                    Console.Write($"{addNumber1} + {addNumber2} = ");  //original line
                    Console.Write(calculator.Add(addNumOne, addNumTwo)); //original line
                    break;
                    //first instance of original code left in for reference
                    //Console.WriteLine("Enter 2 integers to add");
                    //var addNumber1 = Console.ReadLine();
                    //var addNumber2 = Console.ReadLine();

                    //if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    //{
                    //    Console.Write($"{addNumber1} + {addNumber2} = ");
                    //    Console.Write(calculator.Add(addNumOne, addNumTwo));
                    //}
                    //else
                    //{
                    //    Console.WriteLine("One or more of the numbers is not an int");
                    //}
                    //break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract"); //original line
                    var (subtractNumber1, subtractNumber2) = ValidateIntegers(); //run our new method
                    var (subNumOne, subNumTwo) = (subtractNumber1, subtractNumber2); // extra line so we don't have to modify original variables

                    Console.Write($"{subtractNumber1} - {subtractNumber2} = ");  //original line
                    Console.Write(calculator.Subtract(subNumOne, subNumTwo)); //original line
                    break;

                case "3":
                    // Add code here
                    Console.WriteLine("Enter 2 integers to multiply"); //original line
                    var (multiplyNumber1, multiplyNumber2) = ValidateIntegers(); //run our new method
                    var (mulNumOne, mulNumTwo) = (multiplyNumber1, multiplyNumber2); // extra line so we don't have to modify original variables

                    Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");  //original line
                    Console.Write(calculator.Multiply(mulNumOne, mulNumTwo)); //original line
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide"); //original line
                    var (divideNumber1, divideNumber2) = ValidateIntegers(); //run our new method
                    var (divNumOne, divNumTwo) = (divideNumber1, divideNumber2); // extra line so we don't have to modify original variables

                    Console.Write($"{divideNumber1} / {divideNumber2} = ");  //original line
                    Console.Write(calculator.Divide(divNumOne, divNumTwo)); //original line
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }

            static (int, int) ValidateIntegers()
            {
                var inputNumber1 = Console.ReadLine();
                var inputNumber2 = Console.ReadLine();

                if (int.TryParse(inputNumber1, out int intNumber1) && int.TryParse(inputNumber2, out int intNumber2))
                {
                    return (intNumber1, intNumber2);
                }
                else
                {
                    throw new Exception("One or more of the numbers is not an int");  //changing Console.WriteLine to throw an exception prevents "not all code paths return value" error
                }
            }
        }
    }
}