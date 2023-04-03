using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekDemo.Szobak
{
    internal interface ISzobaFactory
    {
        ISzoba Letrehoz(string nev);
    }
}
