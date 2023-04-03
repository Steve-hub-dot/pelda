namespace JatekDemo.Targyak
{
    /// <summary>
    /// A játékban található tárgyakhoz tartozó fő interface
    /// </summary>
    interface ITargy : INezheto
    {
        /// <summary>
        /// A tárgy súlya
        /// </summary>
        int Suly { get; }
    }
}