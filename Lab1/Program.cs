using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        /// <summary>
        /// Find discriminant
        /// </summary>
        /// <returns>discriminant</returns>
        static public int Discr(List<int>coef){
            return coef[1] * coef[1] - 4 * coef[0] * coef[2];
        }
        /// <summary>
        /// Enter coefficients
        /// </summary>
        /// <returns>Coefficients List</returns>
        static public int Coef(){
            string bufCoefficient;
            int coefficient;
            bool checkCorrectInput = true;
            do{
                if (checkCorrectInput == false)
                    Console.WriteLine("Неправильно введен коэффициент");
                bufCoefficient = Console.ReadLine();
                checkCorrectInput = int.TryParse(bufCoefficient, out coefficient);
            } while (!checkCorrectInput);
            return coefficient;
        }
        /// <summary>
        /// Solve equation
        /// </summary>
        /// <param name="coef">equation coefficients</param>
        /// <returns>Roots of equation</returns>
        static public List<double> SolveEquation(List<int> coef){
            int discriminant = Discr(coef);
            List<double> result = new List<double>();
            if (discriminant < 0)
                Console.WriteLine("Нет решения");
            if (discriminant == 0){
                double res = -coef[1] / (2 * coef[0]);
                result.Add(res);
                Console.WriteLine("Один корень = {0}", res);
            }
            if (discriminant > 0)
            {
                double res1, res2;
                res1 = (-coef[1] + Math.Sqrt(discriminant)) / (2 * coef[0]);
                res2 = (-coef[1] - Math.Sqrt(discriminant)) / (2 * coef[0]);
                result.Add(res1);
                result.Add(res2);
                Console.WriteLine("Первый корень = {0:F3}, второй корень = {1:F3}", result[0], result[1]);
            }
            return result;
        }
        static void Main(string[] args){
            List<int> coefficients = new List<int>();
            for (int i = 0; i < 3; i++) {
                coefficients.Add(Coef());
            }
            int discriminant = Discr(coefficients);
            SolveEquation(coefficients);
        }
    }
}
