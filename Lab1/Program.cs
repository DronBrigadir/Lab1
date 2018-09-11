using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coefficients = new int[3];
            for (int i = 0; i < 3; i++) {
                string bufCoefficient = Console.ReadLine();
                bool checkCorrectInput = int.TryParse(bufCoefficient, out coefficients[i]);
                while (!checkCorrectInput) {
                    Console.WriteLine("Неправильно введен коэффициент, введите заново");
                    bufCoefficient = Console.ReadLine();
                    checkCorrectInput = int.TryParse(bufCoefficient, out coefficients[i]);
                }
            }
            int discriminant = coefficients[1] * coefficients[1] - 4 * coefficients[0] * coefficients[2];
            if (discriminant < 0)
                Console.WriteLine("Нет решения");
            if (discriminant == 0)
                Console.WriteLine("Один корень = {0}", -coefficients[1]/(2*coefficients[0]));
            if (discriminant > 0)  {
                double res1, res2;
                res1 = (-coefficients[1] + Math.Sqrt(discriminant))/(2*coefficients[0]);
                res2 = (-coefficients[1] - Math.Sqrt(discriminant))/(2*coefficients[0]);
                Console.WriteLine("Первый корень = {0:F3}, второй корень = {1:F3}", res1, res2);
            }
        }
    }
}
