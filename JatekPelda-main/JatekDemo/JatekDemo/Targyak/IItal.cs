namespace JatekDemo.Targyak
{
    /// <summary>
    /// Az ital t�pus� t�rgyakhoz
    /// </summary>
    interface IItal: ITargy
    {
        int Szomjoltas { get; }
    }
}