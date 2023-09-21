using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1 (необходимо считать имя пользователя с консоли и поприветствовать его по имени): ");
            Console.WriteLine("Как тебя зовут? (после ввода нажмите enter)");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);

            Console.WriteLine("Упражнение 2.2 (необходимо с консоли считать два целых числа и вывести результат деления одного числа на другое.): ");
            Console.WriteLine("Введите 1 целое число (после ввода нажмите enter): ");
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 целое число (после ввода нажмите enter): ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Не определен");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine("Результат = " + result);
            }

            Console.WriteLine("Домашнее задание 2.1 (необходимо прочитать с консоли букву и вывести за ней букву в алфавитном порядке): ");
            Console.WriteLine("Введите любую букву русского алфавита(после ввода нажмите enter): ");
            char firstLetter = Convert.ToChar(Console.ReadLine());
            if (firstLetter == 'я')
            {
                Console.WriteLine("а");
            }
            else
            {
                char nextLetter = (char)((int)firstLetter + 1);
                Console.WriteLine(nextLetter);
            }

            Console.WriteLine("Домашнее задание 2.2 (необходимо решить квадратное уравнение с нахождением корней, где коэффициенты вводятся пользователем): ");
            Console.WriteLine("Введите коэффициент a(после ввода нажмите enter): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b(после ввода нажмите enter): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент с(после ввода нажмите enter): ");
            double c = Convert.ToDouble(Console.ReadLine());
            var D = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if (D < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней ");
            }
            else
            {
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }
                else
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }

        }
    }
}
