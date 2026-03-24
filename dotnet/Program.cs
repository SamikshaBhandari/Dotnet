using Swap;

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


// prime or composite
// using System;
// namespace Samiksha
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             int n;
//             Console.WriteLine("Enter a number:");
//             n = Convert.ToInt32(Console.ReadLine());
//             if (IsPrime(n))
//             {
//                 Console.WriteLine("{0} is prime number,", n);
//             }
//             else
//             {
//                 Console.WriteLine("{0} is composite number,", n);
//             }

//         }

//         public static bool IsPrime(int n)
//         {
//             int i;
//             for (i = 2; i < n; i++)
//             {
//                 if (n % i == 0)
//                 {
//                     return false;
//                 }

//             }
//             return true;
//         }
//     }
// }


//swap example
using System;
namespace Samiksha
{
    class Program
    {
        public static void Main(string[] args)
        {
            SwaptwoNumbers.swapnumber();
            Swapwithoutthirdnum.SwaptwoNumberswithout();
            HCFtwoInteger.hcf(20, 30);
        }
    }
}