namespace JatekDemo.Targyak
{
    /// <summary>
    /// A fegyver típusú tárgyakhoz
    /// </summary>
    interface IFegyver: ITargy
    {
        int Sebzes { get; }
    }
}
