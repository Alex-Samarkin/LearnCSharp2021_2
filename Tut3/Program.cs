using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (от 0 до 100) -> ");
            int value = GetValueFromConsole(Console.ReadLine());

            Console.Write($"Вы задали число {value}");
            Console.ReadLine();

            /// рефактор - код печати вынесен отдельно
            PrintIntValue(value);

            PrintIntValue1(value);

            PrintIntValue2(value);

            Console.WriteLine(IntValueToBarStr(value));

            Console.ReadLine();

        }

        /// <summary>
        /// код печати строки - первый вариант
        /// </summary>
        /// <param name="value"></param>
        private static void PrintIntValue(int value)
        {

            /// 1 строка со стартовыми символами
            var start = "||";
            /// 2 строка с символом-заполнителем
            string bar = new string('-', value);
            /// 3 звездочка
            string end = "*";

            /// TODO
            /// закоментируйте строку string start выше и раскомментируйте следующую
            // string start = $"|{value,4}|";

            Console.WriteLine(start+bar+end);
        }
        /// <summary>
        /// улучшенная (?) функция печати строки
        /// у нее есть параметры, а у параметров есть значения по умолчанию
        /// </summary>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <param name="bar1"></param>
        /// <param name="end"></param>
        private static void PrintIntValue1(int value, 
            string start = "||",char bar1='-',char end = '*')
        {
            /// 2 строка с символом-заполнителем
            string bar = new string('-', value);

            /// TODO
            /// закоментируйте строку string start выше и раскомментируйте следующую
            // string start = $"|{value,4}|";

            Console.WriteLine(start + bar + end);
        }


        /// <summary>
        /// и еще раз улучшенная функция печати, все символы "упакованы в одну строку"
        /// </summary>
        /// <param name="value"></param>
        /// <param name="sample"></param>
        private static void PrintIntValue2(int value,string sample = "||-*")
        {
            /// если строка формата слишком маленькая, то заменяем ее
            /// на корректную
            if (sample.Length <4)
            {
                sample = "[]=>";
            }

            string start = $"{sample[0]}{sample[1]}";
            string bar = new string(sample[2], value);
            char end = sample[3];
            /// TODO
            /// закоментируйте строку string start выше и раскомментируйте следующую
            // string start = $"|{value,4}|";

            /// можно и так
            /// Console.WriteLine($"{sample[0]}{sample[1]}{new string(sample[2], value)}{sample[3]}");
            Console.WriteLine(start + bar + end);
        }
        
        /// <summary>
        /// разделяем ответственность
        /// функция просто выдает строку, а печатает ее вызывающая программа
        /// </summary>
        /// <param name="value"></param>
        /// <param name="sample"></param>
        /// <param name="print_base">надо ли печатать число у основания</param>
        /// <param name="print_head">надо ли печатать число у вершины</param>
        /// <returns>строка для консоли</returns>
        private static string IntValueToBarStr(int value, string sample = "||-*", bool print_base = true,bool print_head = false)
        {
            /// если строка формата слишком маленькая, то заменяем ее
            /// на корректную
            if (sample.Length < 4)
            {
                sample = "[]=>";
            }

            string res = "";

            res += sample[0];
            res += print_base ? $"{value,6}" : "";
            res += sample[1];
            res += new string(sample[2], value);
            res += sample[3];
            res += print_head ? $"{value}" : "";

            // или так
            string res1 = "";

            res1 += sample[0]+
                    (print_base ? $"{value,6}" : "")+
                    sample[1]+
                    new string(sample[2], value)+
                    sample[3]+
                    (print_head ? $"{value}" : "");

            return res;
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
