using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kolok
{
    /// <summary>
    /// Логика взаимодействия для PracownicyViewWindow.xaml
    /// </summary>
    public partial class PracownicyViewWindow : Window
    {
        
        public PracownicyViewWindow(List<Pracownik> pracownicyDoWyswietlenia)
        {
            InitializeComponent();
            DataGridPracownicy.Columns.Add(new DataGridTextColumn
            {
                Header = "Imie",
                Binding = new Binding("Imie")
            });
            DataGridPracownicy.Columns.Add(new DataGridTextColumn
            {
                Header = "Imie1",
                Binding = new Binding("Nazwisko")
            });
            DataGridPracownicy.Columns.Add(new DataGridTextColumn
            {
                Header = "Imie2",
                Binding = new Binding("RokUrodzenia")
            });
            DataGridPracownicy.AutoGenerateColumns = false;
            DataGridPracownicy.ItemsSource = pracownicyDoWyswietlenia;
            DataContext = statyczny.Pracownicy;
        }

       

        private void DodajClick(object sender, RoutedEventArgs e)
        {
            
            DodajPrac dodajPrac = new DodajPrac();
            dodajPrac.ShowDialog();
            statyczny.Pracownicy.Add(statyczny.pracownik);
            DataGridPracownicy.Items.Refresh();
            return;
        }
    }
}
