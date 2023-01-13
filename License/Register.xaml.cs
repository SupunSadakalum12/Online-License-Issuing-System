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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace License
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO `form`(`Name`, `Address`, `Mobile Number`, `Mail Address`, `Username`) VALUES ('"+name.Text+"','"+add.Text+"','"+mn.Text+"','"+ma.Text+"','"+user.Text+"')";
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
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            name.Clear();
            add.Clear();
            mn.Clear();
            ma.Clear();
            user.Clear();
            pass.Clear();
        }

        private void mn_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
