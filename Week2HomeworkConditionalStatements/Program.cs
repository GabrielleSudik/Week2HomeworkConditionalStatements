using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2HomeworkConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem one

            Console.WriteLine("Please write a number between 1 and 100.");
            int intA = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter another number between 1 and 100.");
            int intB = int.Parse(Console.ReadLine());

            if (intA == intB)
            {
                Console.WriteLine("Your two numbers are equal. Duh.");
            }

            else
            {
                Console.WriteLine("Your two numbers are not equal. Duh.");
            }

            //problem two

            Console.WriteLine("\nPlease type any integer.");
            int number2 = int.Parse(Console.ReadLine());

            if (number2 % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }

            else
            {
                Console.WriteLine("Your number is odd.");
            }

            //problem three

            Console.WriteLine("\nAnd enter yet another number.");
            int number3 = int.Parse(Console.ReadLine());

            if (number3 > 0)
            {
                Console.WriteLine($"The number {number3} is positive.");
            }

            else if (number3 < 0)
            {
                Console.WriteLine($"The number {number3} is negative.");
            }

            else
            {
                Console.WriteLine("Let me tell you about the history of the zero...\n" +
                    "It did not exist in either Egyptian or Roman numerals. Early math was significantly " +
                    "hindered by the absense of the concept of Nothing As A Number...");
            }

            //problem four

            Console.WriteLine("\nNow type a letter.");
            char letter = char.Parse(Console.ReadLine());

            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"The letter {letter} is a vowel.");
                    break;
                case 'y':
                    Console.WriteLine($"Sometimes {letter} is a consonant, and sometimes a vowel.");
                    break;
                default:
                    Console.WriteLine($"The letter {letter} is a consonant.");
                    break;
            }

            //problem 5a

            Console.WriteLine("\nOnce again, input a number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("And input another number.");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is the larger number.");
            }

            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} is the larger number.");
            }

            else
            {
                Console.WriteLine("The two numbers are equal.");
            }

            //problem 5b

            Console.WriteLine("\nLet's make that harder. Enter the first of three numbers.");
            int num1st = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second of three numbers.");
            int num2nd = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third and final number.");
            int num3rd = int.Parse(Console.ReadLine());

            if (num1st > num2nd && num1st > num3rd)
            {
                Console.WriteLine($"{num1st} was the largest of the three.");
            }

            if (num2nd > num1st && num2nd > num3rd)
            {
                Console.WriteLine($"{num2nd} was the largest of the three.");
            }

            if(num3rd > num1st && num3rd > num2nd)
            {
                Console.WriteLine($"{num3rd} was the largest of the three.");
            }

            //problem 6

            Console.WriteLine($"\nLast exercise! Enter one number.");
            int numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter a second number.");
            int numB = int.Parse(Console.ReadLine());

            Console.WriteLine("And enter a third number.");
            int numC = int.Parse(Console.ReadLine());

            Console.WriteLine("Finally, enter a fourth number.");
            int numD = int.Parse(Console.ReadLine());

            double mean = (numA + numB + numC + numD) / 4;

            Console.WriteLine($"The mean of {numA} and {numB} and {numC} and {numD} is {mean}.");

            Console.ReadLine();
        }
    }
}
