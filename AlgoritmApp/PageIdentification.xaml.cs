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
    /// Логика взаимодействия для PageIdentification.xaml
    /// </summary>
    public partial class PageIdentification : Page
    {
        public PageIdentification()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Gamer = AppData.Ent.Gamer.FirstOrDefault(x => x.Login == Login.Text);

            if (AppData.Gamer == null)
            {
                MessageBox.Show("Ошибка! Неверный логин!");
            }
            else
            {
                AppData.Gamer.Score = 0;
                AppData.Frame.Navigate(new PageTest());
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnBack2_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new MainPAge());
        }
    }
}
