using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace gggggggggg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader reader = new SQL().Select($@"SELECT UserRole FROM [Trade].[dbo].[User]
                                where UserLogin = '{Login.Text}' and UserPassword = '{Password.Password}' ");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader[0].ToString() == "1")
                    {
                        ролрл sfsfd = new ролрл();
                        sfsfd.ShowDialog();
                    }
                    else if (reader[0].ToString() == "2")
                    {
                        manadger manadger = new manadger();
                        manadger.ShowDialog();
                    }
                    else if (reader[0].ToString() == "3")
                    {
                        user user = new user();
                        user.ShowDialog();
                    }

                 

                }
            }
            else
                MessageBox.Show(reader[0].ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}




