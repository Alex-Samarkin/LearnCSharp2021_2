using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut7
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Добавляем потомка TextChart
            /// он будет обладать еще и заголовком
            /// класс создан в отдельномфайле через меню ДОБАВИТЬ
            /// откройте файл HeadTextChart для дальнейших комментариев
            ///
            ///


            /// Экземпляр класса с диаграммой
            ///
            HeadTextChart htc = new HeadTextChart();

            htc.GenerateNData(10); // 10 данных
            htc.GenerateSeries(true, true);

            Console.WriteLine(htc.WriteHead());
            htc.WriteSeries();

            Console.ReadLine();

            /// просто 1000 данных
            htc.Write();
            Console.ReadLine();
        }
    }
}
