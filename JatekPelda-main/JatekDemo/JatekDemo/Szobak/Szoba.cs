using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekDemo.Szobak
{
    internal class Szoba : ISzoba
    {
        string rovidLeiras;
        string hosszuLeiras;
        ImmutableDictionary<ISzoba.Irany, string> kijaratok;
        IEnumerable<INezheto> latnivalok;
        IEnumerable<INezheto> kereshetok;

        public Szoba(string rovidLeiras, string hosszuLeiras, ImmutableDictionary<ISzoba.Irany, string> kijaratok, IEnumerable<INezheto> latnivalok, IEnumerable<INezheto> kereshetok)
        {
            this.rovidLeiras = rovidLeiras ?? throw new ArgumentNullException(nameof(rovidLeiras));
            this.hosszuLeiras = hosszuLeiras ?? throw new ArgumentNullException(nameof(hosszuLeiras));
            this.kijaratok = kijaratok ?? throw new ArgumentNullException(nameof(kijaratok));
            this.latnivalok = latnivalok ?? throw new ArgumentNullException(nameof(latnivalok));
            this.kereshetok = kereshetok ?? throw new ArgumentNullException(nameof(kereshetok));
        }

        public IEnumerable<INezheto> Latnivalok => latnivalok;

        public string RovidLeiras => rovidLeiras;

        public string HosszuLeiras => hosszuLeiras;

        public ImmutableDictionary<ISzoba.Irany, string> Kijaratok => kijaratok;

        public IEnumerable<INezheto> Kereses() => kereshetok;
    }
}
