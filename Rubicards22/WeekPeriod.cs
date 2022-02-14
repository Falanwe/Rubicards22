using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    [Flags]
    public enum WeekPeriod : byte
    {
        Monday =    1<<0,
        Tuesday =   1<<1,
        Wednesday = 1<<1,
        Thursday =  1<<2,
        Friday =    1<<3,
        Saturday =  1<<4,
        Sunday =    1<<5,
        EveryDay =  Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|Sunday,
        WorkDays = Monday | Tuesday | Wednesday | Thursday | Friday,
        WeekEnd = Saturday|Sunday
    }
}
