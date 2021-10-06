using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C");
            int c = Convert.ToInt32(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int n1 = 0;
            int n2 = 0;
                        
            while (p1 <= a)
            {
                p1 += c;
                n1++;
                if (p1 + c > a)
                {
                    break;
                }
            }
            while (p2 <= b)
            {
                p2 += c;
                n2++;
                if (p2 + c > b)
                {
                    break;
                }
            }

            if (c > a || c > b)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                Console.WriteLine("Количество квадратов со стороной С={0} в прямоугольнике со сторонами А={1} и В={2} равно {3}", c, a, b, n1 * n2);
            }
            
            Console.ReadKey();
        }
    }
}
