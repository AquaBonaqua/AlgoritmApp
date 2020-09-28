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
    /// Логика взаимодействия для PageTest.xaml
    /// </summary>
    public partial class PageTest : Page
    {
        int x, y, z, t, score;
        

        public PageTest()
        {
            InitializeComponent();
            Finish();
            Tryes.Text = AppData.Gamer.Try.TryCount.ToString();
            t = (int)AppData.Gamer.Try.TryCount;
            score = 0;
        }

        public void Finish()
        {
            Answers.Visibility = Visibility.Hidden;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            if (t==0)
            {
                MessageBox.Show("У вас нет попыток!");
                Finish();
            }
            else
            {
                TryesPanel.Visibility = Visibility.Visible;
                x = Convert.ToInt32(Number1.Text);
                y = Convert.ToInt32(Number2.Text);
                z = x * y;
                Random rnd = new Random();
                int ex;
                ex = rnd.Next(1, 4);
                if (ex == 1)
                {
                    Answer1.Content = z;
                    Answer2.Content = rnd.Next(11, 555);
                    Answer3.Content = rnd.Next(11, 999);
                    Answer4.Content = rnd.Next(11, 111);
                }
                if (ex == 2)
                {
                    Answer1.Content = rnd.Next(11, 99);
                    Answer2.Content = z;
                    Answer3.Content = rnd.Next(11, 999);
                    Answer4.Content = rnd.Next(11, 1111);
                }
                if (ex == 3)
                {
                    Answer1.Content = rnd.Next(11, 22);
                    Answer2.Content = rnd.Next(11, 99);
                    Answer3.Content = z;
                    Answer4.Content = rnd.Next(11, 999);
                }
                if (ex == 4)
                {
                    Answer1.Content = rnd.Next(11, 111);
                    Answer2.Content = rnd.Next(11, 999);
                    Answer3.Content = rnd.Next(11, 22);
                    Answer4.Content = z;
                }
                
                Answers.Visibility = Visibility.Visible;
            }
           
        }

       

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.Gamer.Score = score;
            AppData.Ent.SaveChanges();
            AppData.Frame.Navigate(new MainPAge());
           
        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {
            if (t>0)
            {
                if (Convert.ToInt32(Answer1.Content) == z)
                {
                    MessageBox.Show("Молодец!");
                    score++;
                    
                    Finish();
                }

                else
                {
                    MessageBox.Show("Попробуйте ещё раз");
                    t--;
                    Tryes.Text = t.ToString();
                    Finish();

                }
            }

            else
            {
                    MessageBox.Show("У вас нет попыток!");
                Finish();
            }
            
        }

        private void Answer2_Click(object sender, RoutedEventArgs e)
        {
            if (t > 0)
            {
                if (Convert.ToInt32(Answer2.Content) == z)
                {
                    MessageBox.Show("Молодец!");
                    score++;


                    Finish();
                }

                else
                {
                    MessageBox.Show("Попробуйте ещё раз");
                    t--;
                    Tryes.Text = t.ToString();
                    Finish();
                }
            }

            else
            {
                MessageBox.Show("У вас нет попыток!");
                Finish();
            }

        }

        private void Answer3_Click(object sender, RoutedEventArgs e)
        {
            if (t > 0)
            {
                if (Convert.ToInt32(Answer3.Content) == z)
                {
                    MessageBox.Show("Молодец!");
                    score++;


                    Finish();
                }

                else
                {
                    MessageBox.Show("Попробуйте ещё раз");
                    t--;
                    Tryes.Text = t.ToString();
                    Finish();
                }
            }

            else
            {
                MessageBox.Show("У вас нет попыток!");
                Finish();
            }
        }

        private void Answer4_Click(object sender, RoutedEventArgs e)
        {
            if (t > 0)
            {
                if (Convert.ToInt32(Answer4.Content) == z)
                {
                    MessageBox.Show("Молодец!");

                    score++;

                    Finish();
                }

                else
                {
                    MessageBox.Show("Попробуйте ещё раз!");
                    t--;
                    Tryes.Text = t.ToString();
                    Finish();
                }
            }

            else
            {
                MessageBox.Show("У вас нет попыток!");
                Finish();
            }
        }
        
    }
}

