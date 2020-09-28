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
    /// Логика взаимодействия для MainPAge.xaml
    /// </summary>
    public partial class MainPAge : Page
    {
        public MainPAge()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new PageIdentification());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "123")
                {
                    AppData.Frame.Navigate(new PageAdmin());
                }
                else
                    MessageBox.Show("Неверный пароль");
            }
            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new PageResults());
        }
    }
}
