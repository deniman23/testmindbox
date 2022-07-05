using System;

namespace test_mindbox
{
    class Program
    {
        static void Main(string[] args)
        {



            //вывод площади круга
            Circle circle = new Circle();
            Console.WriteLine("Площадь круга: " + circle.sq);

            //вывод площади треугольника
            Triangle triangle = new Triangle();
            Console.WriteLine("Площадь треугольника: " + triangle.sq);

            //вывод большей стороны
            triangle.Check();
            
            
        }
    }

    //класс круга
    public class Circle
    {
        private static double pi = 3.14;
        private static double r = 5;

        public double sq = pi * r * r;
    }

    //класс треугольника
    public class Triangle
    {
        public static double a = 3;
        public static double b = 4;
        public static double c = 5;

        public static double pol = (a+b+c)/2;

        public double sq = Math.Sqrt(pol * (pol - a) * (pol - b) * (pol - c));

        
        public void Check()
        {
            // проверка на большую сторону

            if(a > b & a > c)
            {
                Console.WriteLine('a');
                //проверка на вид треугольника
                if (a * a < c * c + b * b || a * a > c * c + b * b)
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                else
                {
                    Console.WriteLine("Тряугольник прямоугольный");
                }
            }

            if (b > a & b > c)
            {
                Console.WriteLine('b');

                if (b * b < a * a + c * c || b * b > a * a + c * c)
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                else
                {
                    Console.WriteLine("Тряугольник прямоугольный");
                }
            }

            if (c > b & c > a)
            {
                Console.WriteLine('c');

                if ( c*c < a*a + b*b || c * c > a * a + b * b)
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                else
                {
                    Console.WriteLine("Тряугольник прямоугольный");
                }
            }

        }



        //можно добавлять другие фигуры
        
    }

    
        
    
}

