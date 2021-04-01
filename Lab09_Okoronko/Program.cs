using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Okoronko_ver2
{
    class Triangle
    {
        public double a, b, c;
        public double P;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            return;
        }
        public double A 
        { 
            get { return a; } 
            set { a = value > 0 ? value : 0; } 
        }
        public double B 
        { 
            get { return b; } 
            set { b = value > 0 ? value : 0; } 
        }
        public double C 
        { 
            get { return c; } 
            set { c = value > 0 ? value : 0; } 
        }
        // Обоснование существования треугольника
        public bool ExisTruangle()
        {
            bool result = false;
            if ((a + b) > c && (b + c) > a && (c + a) > b)
                result = true;
            return result;
        }
        // Рассчет периметра треугольника
        public double PerTriangle()
        {
            return P = a + b + c;
        }
        // Расчет площади треугольника по формуле Герона
        public double SqrtTriangle()
        {
            return Math.Sqrt(P / 2 * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
        }
        // Вывод результата, если треугольник с такими сторонами существует
        public void OutTriangle()
        {
            //Console.WriteLine(ExisTruangle());
            Console.WriteLine("Периметр треугольника с введенными данными равен: {0}", PerTriangle());
            Console.WriteLine("Площадь данного треугольника равна: {0}", SqrtTriangle());
        }
        // Вывод результата, если треугольник с такими сторонами не существует
        public void MistakeTriangle()
        {
            Console.WriteLine("Вы ввели параметры несущствующего треугольника! ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону треугольника: ");
            double one = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону: ");
            double two = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника: ");
            double three = Double.Parse(Console.ReadLine());

            Triangle newTriangle = new Triangle(one, two, three);
            if (newTriangle.ExisTruangle() == true)
            {
                newTriangle.OutTriangle();
            }
            else
            { 
                newTriangle.MistakeTriangle();
            }

            Console.ReadLine();
        }
    }
}
