// find the HCF of two integers.
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
}

