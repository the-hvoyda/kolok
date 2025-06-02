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
    /// Логика взаимодействия для DodajPrac.xaml
    /// </summary>
    public partial class DodajPrac : Window
    {

        

        public DodajPrac()
        {
            InitializeComponent();
            
        }

        private void przycisk(object sender, RoutedEventArgs e)
        {


                
            statyczny.pracownik.Imie = ImieTextBox.Text;
            statyczny.pracownik.Nazwisko = NazwiskoTextBox.Text;
            statyczny.pracownik.RokUrodzenia = int.Parse(RokText.Text);
            
            
            
            Close();
        }

        
    }
}
