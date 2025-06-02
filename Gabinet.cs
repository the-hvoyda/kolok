using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok
{
    public class Gabinet : IObiekt
    {
        public int Id { get; set; }
        public string Adres { get; set; }
        
        public List<Pracownik> Pracownicy { get; set; }
        public int NumerGabinetu { get; set; }
        public int LicbaPracownikow {
            get
            {
                return Pracownicy.Count;
            }
        }
        public List<Pracownik> WyswietlPracownikow(List<Pracownik> p)
        {
            return this.Pracownicy;
        }
        public override string ToString()
        {
            return $"Gabinet {Id}: {Adres}, Numer: {NumerGabinetu}, Liczba pracowników: {LicbaPracownikow}";
        }
    }
}
