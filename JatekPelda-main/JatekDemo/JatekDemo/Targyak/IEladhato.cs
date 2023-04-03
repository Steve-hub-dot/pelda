namespace JatekDemo.Targyak
{
    /// <summary>
    /// A tárgyaknál a boltos ez alapján dönti el, hogy eladható-e
    /// </summary>
    interface IEladhato: ITargy
    {
        int Ar { get; }
    }
}