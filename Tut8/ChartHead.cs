using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut8
{
    public class ChartHead
    {
        public string Title { get; set; } = "Title";
        public string Description { get; set; } = "Description";
        public string Author { get; set; } = "Author";
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public int Width { get; set; } = 100;

        public string HR(char ch = '=') => new string(ch, Width);
        public string CenterString(string s,char ch = '-')
        {
            string s1 = new string(ch, (Width-s.Length) / 2);
            return s1+s+s1;
        }

        public string HeadStr()
        {
            return HR('=')+"\n"+
                CenterString(Title,' ')+"\n"+
                CenterString(Description,'.')+"\n"+
                HR('-') + "\n" +
                CenterString($"{Author} - {TimeStamp}",' ')+"\n"+
                HR('=');

        }


    }
}
