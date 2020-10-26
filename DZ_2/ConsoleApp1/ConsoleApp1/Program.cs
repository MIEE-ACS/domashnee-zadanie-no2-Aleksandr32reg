using System;
using System.Security.Cryptography.X509Certificates;

namespace DZ_2
{
    class Program
    {
        static double Line(double x, double a, double b)
        {
            double y = a * x + b;
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y, 2);
        }

        static double Circle(double x, double r, double a, double b)
        {
            double y = Math.Sqrt(r * r - (x - a) * (x - a)) - b;
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y, 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите радиус R : ");
            double r = Convert.ToDouble(Console.ReadLine());

            while (r < 0)
            {
                Console.Write("Введите радиус R >= 0 : ");
                r = Convert.ToDouble(Console.ReadLine());
            }

            for (double x = -8; x <= 10; x += 0.2)
            {
                x = Math.Round(x, 2);

                if (x < -8 || x > 10)
                {
                    Console.WriteLine("Функция не определена в данной точке");
                }

                else if (x < -5)
                {
                    if (-r <= x)
                    {
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, Line(x, 0, -3), x, Circle(x, r, 0, 0));
                    }
                    else
                    {
                        Console.WriteLine("y({0}) = {1}", x, Line(x, 0, -3));
                    }
                }

                else if (x == -5)
                {
                    if (-r <= x)
                    {
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} or y({4}) = {5}", x, Line(x, 0, -3), x, Line(x, 1, 3), x, Circle(x, r, 0, 0));
                    }
                    else
                    {
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, Line(x, 0, -3), x, Line(x, 1, 3));
                    }
                }
                else if (x <= -3)
                {
                    if (-r <= x)
                    {
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, Line(x, 1, 3), x, Circle(x, r, 0, 0));
                    }
                    else
                    {
                        Console.WriteLine("y({0}) = {1}", x, Line(x, 1, 3));
                    }
                }

                else if (x <= 3)
                {
                    if (r >= 3)
                    {
                        if (x == 3)
                        {
                            Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, Line(x, 0.6, -1.8), x, Circle(x, r, 0, 0));
                        }
                        else
                        {
                            Console.WriteLine("y({0}) = {1}", x, Circle(x, r, 0, 0));
                        }
                    }
                    else if (x > -r && x < r)
                    {
                        Console.WriteLine("y({0}) = {1}", x, Circle(x, r, 0, 0));
                    }
                    else
                    {
                        Console.WriteLine("Функция не определена в данной точке");
                    }
                }

                else if (x <= 8)
                {
                    if (x <= r)
                    {
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, Line(x, 0.6, -1.8), x, Circle(x, r, 0, 0));
                    }
                    else
                    {
                        Console.WriteLine("y({0}) = {1}", x, Line(x, 0.6, -1.8));
                    }
                }

                else if (x <= 10)
                {
                    if (x <= r)
                    {
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3} ", x, Line(x, 0, 3), x, Circle(x, r, 0, 0));
                    }
                    else
                    {
                        Console.WriteLine("y({0}) = {1}", x, Line(x, 0, 3));
                    }
                }
            }
        }
    }
}
