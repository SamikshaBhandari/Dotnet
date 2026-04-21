namespace ExceptionHandlingDemo{
    class Exception{
        public static void ExceptionHandling(){
            int a,b,c;
            Console.WriteLine("Enter any two numbers");
            try{
                a=int.Parse(Console.ReadLine());
                b=int.Parse(Console.ReadLine());
                c=a/b;
                Console.WriteLine("C VALUE="+c);
            }
                catch (DivideByZeroException dbe)
            {
                Console.WriteLine("2nd number should not be zero"+dbe);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer number"+fe);
            }
            finally
            {
                Console.WriteLine("hello this is finally block");
            }
        
            
        }
    }
}