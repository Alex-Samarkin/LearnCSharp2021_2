using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Стандартный массив
            /// хранит некоторое количество одинаковых по типу элементов
            /// доступ к элементам через оператор [index]
            /// массив обладает размером (длиной) - количеством элементов в массиве
            /// первый элемент имеет индекс 0
            /// в новых версиях C# есть готовые диапазоны, срезы и отрицательные индексы
            /// 
            int[] vs = { 1, 2, 3};
            Console.WriteLine(vs[0]);
            Console.WriteLine($"vs[1] {vs}"); // сравните со следующим
            Console.WriteLine($"vs[1] {vs[1]}");
            
            /// добавляем элемент в хвост массива
            vs.Append(vs[2]+1);
            Console.WriteLine($"vs[1] {vs[1]} vs[2] {vs[2]}");

            Console.ReadLine();

            /// массивы - идеальный объект для применения циклов
            /// в цикле к элементам массива применяется некая операция
            /// далее массив заполняется случайными числами
            /// 
            int N = 1500; // длина массива
            int From = 0; // границы массива по величине
            int To = 101;

            var r = new Random(); // генератор случайных чисел

            vs = new int[N]; // создаем массив заново
                             // Вопрос: что со старым массивом?

            /// заполняем массив случайными числами
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = r.Next(From, To);
            }

            /// печатаем элементы массива в строку
            /// 
            /// цикл foreach просто перебирает все элементы в массиве, 
            /// это проще и безопаснее, чем считать длину
            foreach (var item in vs)
            {
                Console.Write($"{item,6}, ");
            }
            Console.ReadLine();

            /// печатаем массив в строку вместе с номером элемента
            /// 
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine($"| {i,6} | {vs[i],8} |");
            }
            Console.ReadLine();
        }
    }
}
