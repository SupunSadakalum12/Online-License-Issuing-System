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
using MySql.Data.MySqlClient;

namespace License
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO `sign up`(`User name`, `PassWord`) VALUES ('"+un.Text+"','"+pw.Password+"')";
            string server = "localhost";
            string database = "license";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "Password=" + password + ";";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            System.Diagnostics.Debug.WriteLine("fek");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            Hide();
            Interface mainWindow = new Interface();
            mainWindow.ShowDialog();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
