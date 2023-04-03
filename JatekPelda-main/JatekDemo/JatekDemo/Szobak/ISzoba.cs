using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace JatekDemo.Szobak
{
    /// <summary>
    /// A szobák mûködéséhez tartozó interface
    /// </summary>
    interface ISzoba : INezheto
    {
        enum Irany { Észak, Dél, Kelet, Nyugat};
        IEnumerable<INezheto> Latnivalok { get; }

        IEnumerable<INezheto> Kereses();
        ImmutableDictionary<Irany, string> Kijaratok { get; }
    }
}