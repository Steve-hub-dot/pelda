using JatekDemo.Lenyek;
using JatekDemo.Targyak;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JatekDemo.Szobak.ISzoba;

namespace JatekDemo.Szobak
{
    internal class FileSzobaFactory : ISzobaFactory
    {
        string konyvtar;
        Dictionary<string, ISzoba> marBetoltott = new Dictionary<string, ISzoba>();
        ITargyFactory targyFactory;
        ILenyFactory lenyFactory;
        Irany toIrany(char c) => c switch
        {
            'D' => Irany.Dél,
            'K' => Irany.Kelet,
            'E' => Irany.Észak,
            'N' => Irany.Nyugat,
            _ => throw new System.Exception("Érvénytelen irányjelző: " + c),
        };
        public FileSzobaFactory(ITargyFactory targyFactory, ILenyFactory lenyFactory, string konyvtar = "") {
            this.targyFactory = targyFactory??throw new ArgumentNullException(nameof(targyFactory));
            this.lenyFactory = lenyFactory ?? throw new ArgumentNullException(nameof(lenyFactory));
            if (string.IsNullOrWhiteSpace(konyvtar))
            {
                this.konyvtar = "Szobak";
            }
            else { 
                this.konyvtar = konyvtar;
            }
        }
        const char ElemElvalaszto = ';';
        const char ErtekElvalaszto = ':';
        ImmutableDictionary<Irany, string> parseKijaratok(string line) =>
            line.Split(ElemElvalaszto).Select(x => x.Split(ErtekElvalaszto)).ToImmutableDictionary(x => toIrany(x[0][0]), x => x[1]);
        INezheto parseNezheto(string nezheto) => nezheto.Split(ErtekElvalaszto)[0] switch {
            "Targy" => targyFactory.Letrehoz(nezheto.Split(ErtekElvalaszto)[1]),
            "Leny" => lenyFactory.Letrehoz(nezheto.Split(ErtekElvalaszto)[1]),
            _ => throw new InvalidDataException("Nem értelmezhető típus: "+ nezheto.Split(ErtekElvalaszto)[0]),
        };
        IEnumerable<INezheto> parseNezhetok(string line) => line.Split(ElemElvalaszto).Select(parseNezheto).ToList();

        public ISzoba Letrehoz(string nev)
        {
            if (marBetoltott.ContainsKey(nev)) return marBetoltott[nev];
            string fileNev = Path.Combine(konyvtar, nev + ".txt");
            if (!File.Exists(fileNev))
            {
                throw new FileNotFoundException(fileNev);
            }
            var lines = File.ReadAllLines(fileNev);
            ISzoba ret = new Szoba(
                rovidLeiras: lines[0],
                hosszuLeiras: lines[1],
                kijaratok: parseKijaratok(lines[2]),
                latnivalok: parseNezhetok(lines[3]),
                kereshetok: parseNezhetok(lines[4])
                );
            marBetoltott.Add(nev, ret );
            return ret;
        }
    }
}
