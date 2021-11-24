using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChartHead chartHead = new ChartHead();
            Console.WriteLine(chartHead.HeadStr());
            Console.ReadLine();

            HeadTextChart headTextChart = new HeadTextChart();
            headTextChart.Write(40);
            Console.ReadLine();

            headTextChart.Ints.Sort();
            headTextChart.Write(40,false);
            Console.ReadLine();


        }
    }
}
