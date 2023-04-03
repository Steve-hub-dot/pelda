namespace JatekDemo
{
    /// <summary>
    /// A j�t�kban tal�lhat� n�zhet� dolgokhoz tartoz� interface
    /// </summary>
    public interface INezheto
    {
        /// <summary>
        /// A szob�kban �s a boltokban a megjelen�t�se
        /// </summary>
        string RovidLeiras { get; }

        /// <summary>
        /// A le�r�s megjelen�t�se, amikor r�n�z valaki
        /// </summary>
        string HosszuLeiras { get; }
    }

}