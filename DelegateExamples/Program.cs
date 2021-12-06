using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    public delegate int Operation(int first, int second);
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            //Message mes;
            //if (DateTime.Now.Hour<12)
            //{
            //    mes = GoodMorning;
            //}
            //else
            //{
            //    mes = GoodEvening;
            //}
            //mes();

            //Operation op = Add;
            //op += Multiply;
            //int res = Add(4, 5);
            //int res1 = Multiply(4, 5);
            //Console.WriteLine($"{res},{res1}");

            Calculator calculator = new Calculator();
            int result = calculator.Calculate(Add, 4, 9);
            int result1 = calculator.Calculate(Multiply, 5, 5);
            int result2 = calculator.Calculate((x, y) => x / y, 22, 2);
            Console.WriteLine($"{result},{result1},{result2}");

            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening!");
        }

        private static int Add(int first, int second)
        {
            return first + second;
        }
        private static int Multiply(int first, int second)
        {
            return first * second;
        }


    }
}
