using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace gggggggggg
{
    /// <summary>
    /// Логика взаимодействия для ролрл.xaml
    /// </summary>
    public partial class ролрл : Window
    {
        public ролрл()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Clients.Children.Clear();
            SqlDataReader reader = new SQL().Select(@"SELECT
                                    [UserID]
                                  ,[UserSurname]
                                  ,[UserName]
                                  ,[UserPatronymic]
                               FROM [Trade].[dbo].[User]");
            while (reader.Read())
            {
                Client client = new Client();
                client.FirstName.Content = reader[1].ToString();
                client.LastName.Content = reader[2].ToString();
                client.fff.Content = reader[3].ToString();
                client.UserID = reader[0].ToString();
                Clients.Children.Add(client);
            }
        }

      
    }
}
