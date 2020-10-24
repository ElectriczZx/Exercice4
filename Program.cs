using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Squareroot sqrt = new Squareroot();

            Console.Write("Please input a Number: ");
            sqrt.setNumber(double.Parse(Console.ReadLine()));
            Console.WriteLine("Squareroot of: "+sqrt.getNumber()+" is: "+sqrt.getSqrt());
        }
    }
}
