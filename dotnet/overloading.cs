namespace Overloading
{
    class Overloadingmethod
    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum of two number:" + sum);
        }
        public void Add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("Sum of Three Number:" + sum);
        }
    }
}