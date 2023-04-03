using System.Collections.Generic;
using JatekDemo.Targyak;
namespace JatekDemo.Lenyek
{
    /// <summary>
    /// A játékban található lényekhez tartozó fõ interface
    /// </summary>
    interface ILeny : INezheto
    {
        IEnumerable<ITargy> Targyak { get; }
    }
}