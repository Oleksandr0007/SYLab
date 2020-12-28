using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;


namespace Lab3._1
{
    public class Rectangle
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        public double getside1()
        {
            Console.WriteLine("Please enter the first side: ");
            side1 = double.Parse(Console.ReadLine());
            return side1;
        }
        public double getside2()
        {
            Console.WriteLine("Please enter the second side: ");
            side2 = double.Parse(Console.ReadLine());
            return side2;
        }
        public double getper()
        {
            double perimeter;
            perimeter = (getside1() + getside2()) * 2;
            return perimeter;
        }
        public double getpl()
        {
            double square;
            square = getside1() * getside2();
            return square;
        }

    }

    class Prog1
    {
        static void Main(string[] args)
        {
            Rectangle perimeter = new Rectangle();
            Rectangle square = new Rectangle();
            Console.WriteLine("Perimetr is: " + perimeter.getper());
            Console.WriteLine("Square is: " + square.getpl());
        }

    }

}
