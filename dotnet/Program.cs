//Sum of NUmber

// namespace Samiksha;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int firstNum, secondNum, sum;
//         Console.Clear();
//         Console.WriteLine("Enter first number:");
//         firstNum = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter second number:");
//         secondNum = Convert.ToInt32(Console.ReadLine());
//         sum = firstNum + secondNum;
//         Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " is: " + sum);
//         Console.WriteLine("Press any key to exit...");
//         Console.ReadKey();
//     }
// }

//Bitwise operator 
// using System;

// namespace Byte
// {
//     class Byteoperation
//     {
//         static void Main(string[] args)
//         {
//             byte first = 14, second = 9;
//             Console.WriteLine("Bitwise OR of {0} and {1} is {2}.", first, second, first | second);
//             Console.WriteLine("Bitwise AND of {0} and {1} is {2}.", first, second, first & second);
//             Console.WriteLine("Bitwise XOR of {0} and {1} is {2}.", first, second, first ^ second);
//             Console.WriteLine("Bitwise NOT of {0} is {1}.", first, ~first);
//             Console.WriteLine("Left shift of {0} by 1 is {1}", first, first << 1);
//             Console.WriteLine("\nPress any key to exit...");
//             Console.ReadKey();
//         }
//     }
// }



//Conditional operator
// using System;
// namespace Samiksha
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a number:");
//             int number = Convert.ToInt32(Console.ReadLine());
//             string result = (number >= 0) ? "Positive" : "Negative";
//             Console.WriteLine("The number is: " + result);
//             Console.ReadKey();
//         }
//     }
// }

//relational operator
// using System;

// namespace Samiksha
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter first number (a):");
//             int a = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter second number (b):");
//             int b = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("\n Comparison Results");
//             Console.WriteLine("Is a equal to b? : " + (a == b));
//             Console.WriteLine("Is a greater than b? : " + (a > b));
//             Console.WriteLine("Is a less than b? : " + (a < b));
//             Console.WriteLine("Is a greater than or equal to b? : " + (a >= b));
//             Console.WriteLine("Is a less than or equal to b? : " + (a <= b));
//             Console.ReadKey();
//         }
//     }
// }

// arithmetic operator subtract
// using System;

// namespace Samiksha
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int num1, num2, difference;
//             Console.WriteLine("Subtraction Program");
//             Console.WriteLine("Enter the first number:");
//             num1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter the second number to subtract:");
//             num2 = Convert.ToInt32(Console.ReadLine());
//             difference = num1 - num2;
//             Console.WriteLine("\nThe result of " + num1 + " - " + num2 + " is: " + difference);
//             Console.WriteLine("\nPress any key to exit..");
//             Console.ReadKey();
//         }
//     }
// }

//Multipication 

using System;

namespace Samiksha
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, product;

            Console.WriteLine("Multiplication Program");
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            product = num1 * num2;
            Console.WriteLine("\nResult: " + num1 + " * " + num2 + " = " + product);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}