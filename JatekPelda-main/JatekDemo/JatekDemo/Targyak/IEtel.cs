namespace JatekDemo.Targyak
{
    /// <summary>
    /// Az étel típusú tárgyakhoz
    /// </summary>
    interface IEtel: ITargy
    {
        int Tapertek { get; }        
    }
}