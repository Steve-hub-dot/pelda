namespace JatekDemo
{
    /// <summary>
    /// A játékban található nézhetõ dolgokhoz tartozó interface
    /// </summary>
    public interface INezheto
    {
        /// <summary>
        /// A szobákban és a boltokban a megjelenítése
        /// </summary>
        string RovidLeiras { get; }

        /// <summary>
        /// A leírás megjelenítése, amikor ránéz valaki
        /// </summary>
        string HosszuLeiras { get; }
    }

}