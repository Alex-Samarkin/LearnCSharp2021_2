// LearnCSharp2021_2
// Tut6
// TextChart.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 2:25 24 11 2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Tut6
{
    public class TextChart
    {
        /// <summary>
        /// 1 "правильные границы данных"
        /// </summary>
        private const int From = 0;
        private const int To = 101;

        /// <summary>
        /// 2 список с целыми числами (для отображения)
        /// изначально список пустой
        /// </summary>
        public List<int> Ints { get; set; } = new List<int>();

        /// <summary>
        /// 3 Добавить целое число с проверкой на попадание в интевал [From ; To[
        /// </summary>
        /// <param name="Value"> переменная для добавления </param>
        public void Add(int Value)
        {
            if (Value < From) Value = From;
            if (Value >= To) Value = To - 1;
            Ints.Add(Value);
        }

        /// <summary>
        /// 4 добавляем строку, которую преобразуем в целое и добавляем к данным
        /// два метода Add отличаются типом аргумента, так МОЖНО - называется перегрузка
        /// </summary>
        /// <param name="Value"> строка, которую преобразовываем </param>
        public void Add(string Value)
        {
            /// преобразовываем строку в целое с проверками
            int value = From;
            if (int.TryParse(Value, out value) == false)
            {
                // если строка неправильная, задаем value значение From
                value = From;
            }

            /// для добавления целого числа УЖЕ есть метод
            Add(value);
        }

        /// <summary>
        /// 5 генератор случайных чисел, он нужен только для генерации тестовых данных
        /// поэтому он сделан private - невидимым снаружи класса
        /// </summary>
        private Random Random { get; set; } = new Random();

        /// <summary>
        /// 6 генерация серии случайных чисел объемом N
        /// старые данные удаляются
        /// </summary>
        /// <param name="N">количество данных в серии</param>
        public void GenerateNData(int N = 1000)
        {
            Ints.Clear();
            /// заполняем массив случайными числами 
            for (int i = 0; i < N; i++)
            {
                Ints.Add(Random.Next(From, To)); // именно Add
            }
        }

        /// <summary>
        /// 7 строка для оформления графика
        /// </summary>
        public string Sample { get; set; } = "[]=>";

        /// <summary>
        /// 8 список для строк с графиком данных
        /// </summary>
        public List<string> Series { get; set; } = new List<string>();

        /// <summary>
        /// 9 генератор строк с представлением данных для последующей печати
        /// </summary>
        /// <param name="print_base">если истинно, то печатаем число в основании </param>
        /// <param name="print_head">если истинно - печатаем число при вершине </param>
        public void GenerateSeries(bool print_base = true, bool print_head = false)
        {
            /// чистим старые данные
            Series.Clear();

            /// если строка формата слишком маленькая, то заменяем ее
            /// на корректную
            if (Sample.Length < 4)
            {
                Sample = "[]=>";
            }

            /// проходим все данные, преобразовываем в строку
            /// добавляем строку к массиву строк-представлений
            foreach (var item in Ints)
            {
                string res = "";

                res += Sample[0];
                res += print_base ? $"{item,6}" : "";
                res += Sample[1];
                res += new string(Sample[2], item);
                res += Sample[3];
                res += print_head ? $"{item}" : "";

                /// добавляем строку в серию
                Series.Add(res);
            }
        }

        /// <summary>
        /// 10 печать предварительно созданных строк
        /// </summary>
        public void WriteSeries()
        {
            foreach (var s in Series)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// 11 все сразу :)
        /// </summary>
        public void Write()
        {
            GenerateNData();
            GenerateSeries();
            WriteSeries();
        }
    }
}