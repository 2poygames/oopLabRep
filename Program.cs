using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;


namespace Lab3_1
{
    class Rectangle
    {
        public double side1;
        public double side2;

        public Rectangle(double _side1, double _side2)
        {
            side1 = _side1;
            side2 = _side2;
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(side1, side2); }
        }

        public double Area
        {
            get { return AreaCalculator(side1, side2); }
        }

        public static double AreaCalculator(double a, double b)
        {
            return a * b;
        }

        public static double PerimeterCalculator(double a, double b)
        {
            return 2 * a + 2 * b;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Уведіть дві сторони прямокутника:");

            string strRectSide1 = Console.ReadLine();
            string strRectSide2 = Console.ReadLine();

            

            double side1 = Convert.ToDouble(strRectSide1);
            double side2 = Convert.ToDouble(strRectSide2);

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"перша сторона: {rectangle.side1}, друга сторона: {rectangle.side2}");
            Console.WriteLine($"периметр: {rectangle.Perimeter}, площа: {rectangle.Area}");
            Console.ReadKey();
        }


    }
}