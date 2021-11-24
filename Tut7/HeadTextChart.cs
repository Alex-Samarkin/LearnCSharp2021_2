using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut7
{
    public class HeadTextChart : TextChart
    {
        public string Title { get; set; } = "Заголовок";
        public string SubTitle { get; set; } = "ПодЗаголовок";

        /// <summary>
        /// вспомогательный метод - генерирует строку из 100 повторяющихся символов
        /// </summary>
        /// <param name="ch"> символ для повтора</param>
        /// <returns> строка из 100 символов </returns>
        public string HR(char ch = '_') => new string(ch, 100);

        /// <summary>
        /// вывод строки заголовка
        /// </summary>
        /// <returns> строка с заголовками и рамками </returns>
        public string WriteHead()
        {
            return HR() + "\n" + Title + "\n" + SubTitle + "\n" + HR() + "\n";
        }

        /// <summary>
        /// переделанный метод базового класса
        /// </summary>
        public override void Write()
        {
            /// сначала печатаем строку заголовка
            Console.WriteLine(WriteHead());
            /// используем метод базового класса
            base.Write();
            Console.WriteLine(HR());
        }

    }
}
