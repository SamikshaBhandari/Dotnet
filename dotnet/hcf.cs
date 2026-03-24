// find the HCF of two integers.

namespace findHCF
{
    class HCFtwoInteger
    {
        public static void hcf(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine("HCF is:" + a);
        }
        public static void hcfusingforloop()
        {
            int a, b, hcf = 1;
            Console.Write("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            int min = a < b ? a : b;
            for (int i = 2; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine("The hcf is:" + hcf);
        }
    }
}
