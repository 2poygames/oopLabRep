using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Lab3_3
{
    class Point
    {
        public int x;
        public int y;
        public string str;

        public Point(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.str = str;
        }
    }
    class Figure
    {
        public Figure(Point frstPoint, Point scndPoint, Point thrdPoint)
        {
            Console.WriteLine("Фігура: трикутник");

            double Alenghts = Lenghtside(frstPoint, scndPoint);
            double Blenghts = Lenghtside(scndPoint, thrdPoint);
            double Clenghts = Lenghtside(frstPoint, thrdPoint);

            double perimeter = Perimeter(Alenghts, Blenghts, Clenghts, 0, 0);

            Console.WriteLine($"Периметр: {perimeter}");


            Console.WriteLine($"сторона A: {Alenghts}");
            Console.WriteLine($"сторона B: {Blenghts}");
            Console.WriteLine($"сторона C: {Clenghts}");
        }

        public Figure(Point frstPoint, Point scndPoint, Point thrdPoint, Point frthPoint)
        {
            Console.WriteLine("Фігура: чотирикутник");

            double Alenghts = Lenghtside(frstPoint, scndPoint);
            double Blenghts = Lenghtside(scndPoint, thrdPoint);
            double Clenghts = Lenghtside(thrdPoint, frthPoint);
            double Dlenghts = Lenghtside(frstPoint, frthPoint);

            double perimeter = Perimeter(Alenghts, Blenghts, Clenghts, Dlenghts, 0);

            Console.WriteLine($"Периметр: {perimeter}");


            Console.WriteLine($"сторона A: {Alenghts}");
            Console.WriteLine($"сторона B: {Blenghts}");
            Console.WriteLine($"сторона C: {Clenghts}");
            Console.WriteLine($"сторона D: {Dlenghts}");
        }

        public Figure(Point frstPoint, Point scndPoint, Point thrdPoint, Point frthPoint, Point ffthPoint)
        {
            Console.WriteLine("Фігура: п'ятикутник");

            double Alenghts = Lenghtside(frstPoint, scndPoint);
            double Blenghts = Lenghtside(scndPoint, thrdPoint);
            double Clenghts = Lenghtside(thrdPoint, frthPoint);
            double Dlenghts = Lenghtside(frthPoint, ffthPoint);
            double Elenghts = Lenghtside(frstPoint, ffthPoint);

            double perimeter = Perimeter(Alenghts, Blenghts, Clenghts, Dlenghts, Elenghts);

            Console.WriteLine($"Периметр: {perimeter}");

            Console.WriteLine($"сторона A: {Alenghts}");
            Console.WriteLine($"сторона B: {Blenghts}");
            Console.WriteLine($"сторона C: {Clenghts}");
            Console.WriteLine($"сторона D: {Dlenghts}");
            Console.WriteLine($"сторона E: {Elenghts}");
        }
        public static double Lenghtside(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }

        public static double Perimeter(double A, double B, double C, double D, double E)
        {
            return A + B + C + D + E;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Point a = new Point(1, 1, "a");
            Point b = new Point(2, 4, "b"); 
            Point c = new Point(4, 4, "c");
            Point d = new Point(6, 2, "d");
            Point e = new Point(8, 1, "e");

            Figure triangle = new Figure(a, b, c);
            Figure square = new Figure(a, b, c, d);
            Figure pentagon = new Figure(a, b, c, d, e);
        }
    }
}


