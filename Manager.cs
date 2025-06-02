using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok
{
    public class Manager
    {
        public List<Gabinet> Gabinety { get; set; }
        public void DodajGabinet(Gabinet g)
        {
            if (Gabinety == null)
            {
                Gabinety = new List<Gabinet>();
            }
            Gabinety.Add(g);
        }
        public void DodajPracownika(Gabinet g, Pracownik p)
        {
            if (g.Pracownicy == null)
            {
                g.Pracownicy = new List<Pracownik>();
            }
            g.Pracownicy.Add(p);
        }
        public List<Gabinet> ZnajdzGabinety(Func<Gabinet, bool> pred)
        {
            if (Gabinety == null)
            {
                return new List<Gabinet>();
            }
            return Gabinety.Where(pred).ToList();
        }
        public List<Pracownik> ZnajdzPracownikow(Func<Pracownik, bool> pred)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            if (Gabinety != null)
            {
                foreach (var g in Gabinety)
                {
                    if (g.Pracownicy != null)
                    {
                        pracownicy.AddRange(g.Pracownicy.Where(pred));
                    }
                }
            }
            return pracownicy;
        }
    }
}
