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
using System.Windows.Shapes;

namespace gggggggggg
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (firstname.Text.Length > 3
                && lastname.Text.Length > 3
                && patronymic.Text.Length > 3
                && login.Text.Length > 3
                && password.Text == passwordrepeat.Text)
            {

                string command = $@"INSERT INTO [dbo].[User]
            ([UserSurname]
            ,[UserName]
            ,[UserPatronymic]
            ,[UserLogin]
            ,[UserPassword]
            ,[UserRole])
    VALUES
            ('{login.Text}'
            ,'{firstname.Text}'
            ,'{patronymic.Text}'
            ,'{login.Text}'
            ,'{password.Text}'
            ,3)";
                new SQL().InsDelUpd(command);
            }
        }
    }
}
