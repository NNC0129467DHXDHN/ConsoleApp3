using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamgiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So do canh a la: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("So do canh b la: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("So do canh c la: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine("Ba cạnh tạo thành một tam giác.");
                }
                else
                {
                    Console.WriteLine("Ba cạnh không tạo thành một tam giác.");
                }
            }

        }
    }
}

