using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok
{
    public class Pracownik : IObiekt
    {
        
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int RokUrodzenia { get; set; }
        public int MiesiacUrodzenia { get; set; }
        public int DzienUrodzenia { get; set; }
        public int Id { get; set; }

    }
}
