using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut8
{
    public class HeadTextChart : TextChart
    {
        public ChartHead Head { get; set; } = new ChartHead();

        public override void Write(int N = 1000, bool Regenerate = true)
        {
            Console.WriteLine(Head.HeadStr());
            base.Write(N,Regenerate);
            Console.WriteLine(Head.HR());
        }
    }
}
