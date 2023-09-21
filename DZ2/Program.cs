using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DZ2
{

internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1.\nтип данных – максимальное значение – минимальное значение");
            Console.WriteLine("byte - {0} - {1}", Byte.MaxValue, Byte.MinValue);
            Console.WriteLine("sbyte - {0} - {1}", SByte.MaxValue, SByte.MinValue);
            Console.WriteLine("short - {0} - {1}", Int16.MaxValue, Int16.MinValue);
            Console.WriteLine("ushort - {0} - {1}", UInt16.MaxValue, UInt16.MinValue);
            Console.WriteLine("int - {0} - {1}", Int32.MaxValue, Int32.MinValue);
            Console.WriteLine("uint - {0} - {1}", UInt32.MaxValue, UInt32.MinValue);
            Console.WriteLine("long - {0} - {1}", Int64.MaxValue, Int64.MinValue);
            Console.WriteLine("ulong - {0} - {1}", UInt64.MaxValue, UInt64.MinValue);
            Console.WriteLine("float - {0} - {1}", Single.MaxValue, Single.MinValue);
            Console.WriteLine("double - {0} - {1}", Double.MaxValue, Double.MinValue);
            Console.WriteLine("decimal - {0} - {1}", Decimal.MaxValue, Decimal.MinValue);
            Console.WriteLine("bool - True - False");
            Console.WriteLine("char - {0} - {1}", Char.MaxValue, Char.MinValue);
            Console.WriteLine("string - N/A - N/A");
            Console.WriteLine("object - N/A - N/A");
            Console.WriteLine("dynamic - N/A - N/A");

            Console.WriteLine("Задание 2. (написать программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода): ");
            string name, city, PIN;
            int age;
            Console.WriteLine("Введите ваше имя (после ввода нажмите enter): ");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш город (после ввода нажмите enter): ");
            city = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст (после ввода нажмите enter): ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш PIN-код (после ввода нажмите enter): ");
            PIN = Console.ReadLine();
            Console.WriteLine($"Ваше имя: {name}");
            Console.WriteLine($"Ваш город: {city}");
            Console.WriteLine($"Ваш возраст: {age}");
            Console.WriteLine($"Ваш PIN-код: {PIN}");

            Console.WriteLine("Задание 3. (строчные буквы заменить на заглавные, заглавные – на строчные): ");
            string str, str1;
            Console.Write("Введите строку (после ввода нажмите enter): ");
            str = Console.ReadLine();
            str1 = str;
            str = string.Concat(str.ToLower().ToUpper());
            str1 = string.Concat(str.ToUpper().ToLower());
            Console.WriteLine("Преоброзование в заглавные: " + str);
            Console.WriteLine("Преоброзование в строчныес: " + str1);

            Console.WriteLine("Задание 4. (необходимо найти количество вхождений): ");
            Console.WriteLine("Введите 1 строку (после ввода нажмите enter): ");
            string input = Console.ReadLine();
            Console.WriteLine("Введите 2 строку (после ввода нажмите enter): ");
            string search = Console.ReadLine();
            int count = Regex.Matches(input, search).Count;
            Console.WriteLine(search + " было найдено " + count + " раз");

            Console.WriteLine("Задание 5. (определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы покрыть отпуск с округлением в меньшую сторону): ");
            Console.WriteLine("Введите цену бутылки виски без скидки (после ввода нажмите enter): ");
            int normPrice = Convert.ToInt32(Console.ReadLine()); // обычная цена бутылки виски
            Console.WriteLine("Введите скидку в процентах (после ввода нажмите enter): ");
            int salePrice = Convert.ToInt32(Console.ReadLine());  // скидка в Duty Free
            Console.WriteLine("Введите стоимость отпуска: (после ввода нажмите enter): ");
            int holidayPrice = Convert.ToInt32(Console.ReadLine()); // стоимость отпуска
            double savingsPerBottle = normPrice - (normPrice * (100 - salePrice) / 100); // сколько мы экономим на каждой бутылке
            int bottlesNeeded = Convert.ToInt32(Math.Floor(holidayPrice / savingsPerBottle)); // сколько бутылок нам нужно купить
            Console.WriteLine("Вам нужно купить " + bottlesNeeded + " бутылок виски.");

            Console.WriteLine("Задание 6. (воспроизвести разговор Гарри Поттера и дневника Тома Реддла)");
            Console.WriteLine("Дневник Тома Реддла");
            Console.WriteLine("(Поздоровайся): ");
            Console.ReadLine();
            Console.WriteLine("Как твое имя?");
            Console.WriteLine("(Введи своё имя): ");
            string Name = Console.ReadLine();
            Console.WriteLine("Привет, " + Name);
            Console.WriteLine("(Спроси знает ли дневник что-то про тайную комнату): ");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.WriteLine("Спроси может ли рассказать дневник про неё что-то): ");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("но могу показать...");
            Random random = new Random();
            int color = random.Next(0, 16);
            Console.BackgroundColor = (ConsoleColor)color;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(2000);
            Console.Clear();

        }
    }
}
