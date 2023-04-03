using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekDemo.Lenyek
{
    internal interface ILenyFactory
    {
        ILeny Letrehoz(string nev);
    }
}
