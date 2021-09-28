using System;


namespace OperatorExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int quotient, remainder;


            Console.Write("Enter value for a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for b: ");
            b = Convert.ToInt32(Console.ReadLine());

            quotient = Convert.ToInt32(a / b);
            remainder = Convert.ToInt32(a % b);

            Console.WriteLine(a + "/" + b + " is " + quotient +" and remainder is "+ remainder);


        }
    }
}
