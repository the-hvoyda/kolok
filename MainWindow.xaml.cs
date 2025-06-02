using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kolok;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public List<Pracownik> Pracownicy { get; set; } = new List<Pracownik>
    {
        new Pracownik { Imie = "Jan", Nazwisko = "Kowalski", RokUrodzenia = 1985 },
        new Pracownik { Imie = "Anna", Nazwisko = "Nowak", RokUrodzenia = 1990 },
        new Pracownik { Imie = "Piotr", Nazwisko = "Zielinski", RokUrodzenia = 1982 }
    };
    private Manager _manager;
    public MainWindow()

    {
        InitializeComponent();
        _manager = new Manager();
    }

       

    private void PracownikiClick(object sender, RoutedEventArgs e)
    {
        PracownicyViewWindow oknoPracownikow = new PracownicyViewWindow(Pracownicy);
        oknoPracownikow.ShowDialog();
    }

    private void GabinetyClick(object sender, RoutedEventArgs e)
    {

    }
}
