using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolka2
{
    public class MyEvent
    {
        public int MinutesStart { get; set; }
        public int MinutesEnd { get; set; }
        public String Message { get; set; }

        public MyEvent(int minutesStart, int minutesEnd, string message)
        {
            MinutesStart = minutesStart;
            MinutesEnd = minutesEnd;
            Message = message;
        }
    }
}
