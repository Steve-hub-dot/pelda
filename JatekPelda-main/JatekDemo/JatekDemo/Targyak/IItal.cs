namespace JatekDemo.Targyak
{
    /// <summary>
    /// Az ital típusú tárgyakhoz
    /// </summary>
    interface IItal: ITargy
    {
        int Szomjoltas { get; }
    }
}