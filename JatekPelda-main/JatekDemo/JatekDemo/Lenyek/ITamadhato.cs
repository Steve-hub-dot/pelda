using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekDemo.Lenyek
{
    interface ITamadhato: ILeny
    {
        int MaxHP { get; }
        int HP { get; }        
        int Szint { get; }

        bool EletbenVan => HP > 0;
    }
}
