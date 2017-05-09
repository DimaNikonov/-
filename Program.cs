using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace календарь
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, d, g;
            int x, y, m;
            Console.SetBufferSize(150, 400);
            Console.SetWindowSize(150, 45);

            int year;
            Console.Write("введите год:");
            year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, 1, 1);
            DateTime date1 = new DateTime(year, 12, 31);
            for (y = 1; y <= 11; y = y + 10)

            {

                for (x = 0; x <= 120; x = x + 24)
                {
                    int per;
                    per = x;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = (ConsoleColor)date.Month;
                    Console.WriteLine("       {0}", date.ToString("MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
                    Console.ResetColor();
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write(" пн вт ср чт пт сб");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" вс");
                    Console.ResetColor();
                    if (date.DayOfWeek == DayOfWeek.Monday)
                        Console.SetCursorPosition(x, y + 2);
                    if (date.DayOfWeek == DayOfWeek.Tuesday)
                        Console.SetCursorPosition(x + 3, y + 2);
                    if (date.DayOfWeek == DayOfWeek.Wednesday)
                        Console.SetCursorPosition(x + 6, y + 2);
                    if (date.DayOfWeek == DayOfWeek.Thursday)
                        Console.SetCursorPosition(x + 9, y + 2);
                    if (date.DayOfWeek == DayOfWeek.Friday)
                        Console.SetCursorPosition(x + 12, y + 2);
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                        Console.SetCursorPosition(x + 15, y + 2);
                    if (date.DayOfWeek == DayOfWeek.Sunday)
                        Console.SetCursorPosition(x + 18, y + 2);

                    int n;
                    n = y + 3;
                    m = date.Month;
                    for (int i = 1; i <= DateTime.DaysInMonth(year, m); i++)
                    {
                        if (date.DayOfWeek == DayOfWeek.Sunday) Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0,3}", date.Day);
                        if (date.DayOfWeek == DayOfWeek.Sunday)
                        {

                            Console.WriteLine();
                            Console.SetCursorPosition(x, n);
                            n += 1;
                        }
                        date = date.AddDays(1);
                        Console.ResetColor();
                    }
                }

            }
            Console.Read();
        }

    }
}
