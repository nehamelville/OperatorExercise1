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

            Console.WriteLine(a + "/" + b + " is " + quotient + " and remainder is " + remainder);
            AddSpaces(2);

            Console.Write("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of circle with radius of {radius} is {area} ");


        }
        public static double AreaOfCircle(double r)
        {
            const double pi = 3.14f;
            double area = pi * r * r;
            return area;

        }
        public static void AddSpaces(int x)
        {
            while(x!=0)
            {
                Console.WriteLine("");
                x--;
            }
            
        }
    }
}
