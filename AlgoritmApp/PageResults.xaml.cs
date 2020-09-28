using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlgoritmApp
{
    /// <summary>
    /// Логика взаимодействия для PageResults.xaml
    /// </summary>
    public partial class PageResults : Page
    {
        public PageResults()
        {
            InitializeComponent();
            grid.ItemsSource = AppData.Ent.Gamer.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new MainPAge());
        }
    }
}
