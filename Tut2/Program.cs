using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (от 0 до 100) -> ");
            string input = Console.ReadLine();

            /// рефакторинг - действия по вводу перенесены в метод GetValueFromConsole
            int value = GetValueFromConsole(input);
            /// теперь можно даже сделать так:
            /// int value = GetValueFromConsole(Console.ReadLine());
            /// строка считывается прямо при вызове метода

            Console.Write($"Вы задали число {value}");
            Console.ReadLine();

            /// Алгоритм вывода строки
            /// 1 печатаем стартовые символы
            /// 2 печатаем столько символов - , сколько в их в числе
            /// 3 печатаем символ *
            /// Наиболее логично сформировать всю строку, а распечатать ее целиком
            
            /// 1 строка со стартовыми символами
            string start = "||";
            /// 2 строка с символом-заполнителем
            /// вызываем конструктор класса строка
            /// одиночные символы - в одиночных кавычках
            string bar = new string('-', value);
            /// 3 звездочка
            string end = "*";

            /// TODO
            /// закоментируйте строку string start выше и раскомментируйте следующую
            // string start = $"|{value,4}|";

            /// Печать
            Console.WriteLine(start+bar+end);
            Console.ReadLine();

            /// TODO
            /// замените заполнитель на знак =
            /// замените звездочку на ] или >
            /// что, если я хочу видеть на хвосте строки справа еще и значение переменной?
            /// как печатать ОТРИЦАТЕЛЬНЫЕ числа?
            /// как печатать график желтыми символами?
        }

        private static int GetValueFromConsole(string input)
        {
            int value = 0;
            if (int.TryParse(input, out value) == false)
            {
                // если строка неправильная, задаем value значение 0
                value = 0;
            }
            value = value < 0 ? 0 : value;
            value = value > 100 ? 100 : value;
            return value;
        }
    }
}
