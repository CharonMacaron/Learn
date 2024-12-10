using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60;
        }
        public (int, int) SecondsToTime(int sec)
        {
            int ch = sec / 3600;
            sec %= 3600;
            int min = sec / 60;
            return (ch, min);
        }
    }
}
