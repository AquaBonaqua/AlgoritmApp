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
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
            
            AppData.Try = AppData.Ent.Try.FirstOrDefault(x => x.Id == 1);
            Try.Text = AppData.Try.TryCount.ToString();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new MainPAge());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Try.TryCount = Convert.ToInt32(Try.Text);
            AppData.Ent.SaveChanges();
            MessageBox.Show("Сохранено!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
