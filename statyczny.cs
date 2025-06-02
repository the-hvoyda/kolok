using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok
{
    public static class statyczny
    {
        public static ObservableCollection<Gabinet> Gabinety { get; set; } = new ObservableCollection<Gabinet>();
        public static ObservableCollection<Pracownik> Pracownicy { get; set; } = new ObservableCollection<Pracownik>();
        public static Pracownik pracownik = new Pracownik();
    }
}
