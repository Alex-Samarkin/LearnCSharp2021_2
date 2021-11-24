using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Добавляем НОВЫЙ КЛАСС TextChart
            /// он будет собирать данные, формировать массив строк и печатать их в консоли
            /// класс создан в отдельномфайле через меню ДОБАВИТЬ
            /// откройте файл TextChart для дальнейших комментариев
            ///
            ///
            

            /// Экземпляр класса с диаграммой
            ///
            TextChart tc = new TextChart();

            tc.GenerateNData(10); // 50 данных
            tc.GenerateSeries(true,true);
            tc.WriteSeries();

            Console.ReadLine();

            /// просто 1000 данных
            // tc.Write();
        }
    }
}
