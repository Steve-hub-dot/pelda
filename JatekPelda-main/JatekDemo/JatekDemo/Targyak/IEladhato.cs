namespace JatekDemo.Targyak
{
    /// <summary>
    /// A t�rgyakn�l a boltos ez alapj�n d�nti el, hogy eladhat�-e
    /// </summary>
    interface IEladhato: ITargy
    {
        int Ar { get; }
    }
}