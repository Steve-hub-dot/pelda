using System.Collections.Generic;
using JatekDemo.Targyak;
namespace JatekDemo.Lenyek
{
    /// <summary>
    /// A j�t�kban tal�lhat� l�nyekhez tartoz� f� interface
    /// </summary>
    interface ILeny : INezheto
    {
        IEnumerable<ITargy> Targyak { get; }
    }
}