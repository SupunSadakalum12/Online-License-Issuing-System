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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO `pay`(`amount`, `card holder name`, `card number`, `month`, `year`) VALUES ('" + amt.Text+"','"+chn.Text+"','"+cn.Text+"','"+mm.Text+"','"+yy.Text+"')";
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
            MessageBoxResult result = MessageBox.Show("Payment is successful", "Confirmation");
            Hide();
            Interface mainWindow = new Interface();
            mainWindow.ShowDialog();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            amt.Clear();
            chn.Clear();
            cn.Clear();
            sc.Clear();
            mm.Clear();
            yy.Clear();
        }

        private void amt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cn_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void sc_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void mm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void yy_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
