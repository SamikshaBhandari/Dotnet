//swap two numbers using third variable in C#

namespace Swap;

class SwaptwoNumbers
{
    public static void swapnumber()
    {
        int a = 5, b = 7, c;
        c = b;
        b = a;
        Console.WriteLine("a:\t" + c + "\tb:\t" + b);
    }
}

//swap two numbers without using third variable in C#
class Swapwithoutthirdnum
{
    public static void SwaptwoNumberswithout()
    {
        int num1 = 10, num2 = 20;
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
        Console.WriteLine("num1:\t" + num1 + "\tnum2:\t" + num2);
    }
}
class Swaptwostrs
{
    public static void swapstring()
    {
        string a = "samina";
        string b = "susmita";
        a = a + b;
        b = a.Substring(0, a.Length - b.Length);
        a = a.Substring(b.Length);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}