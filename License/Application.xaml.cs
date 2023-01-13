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
    /// Interaction logic for Application.xaml
    /// </summary>
    public partial class Application : Window
    {
        public Application()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO `application`(`ID/Passport Number`, `Full Name`, `Sex`, `Date Of Birth`, `Age`, `Height`, `Blood Group`, `Address`, `Phone Number`, `Authorized By`, `Vehicle Class`, `Vehicle Reg-No:`) VALUES ('"+pno.Text+"','"+fn.Text+"','"+comboBox1.Text+"','"+date.Text+"','"+age.Text+"','"+hei.Text+"','"+bl.Text+"','"+add.Text+"','"+pn.Text+"','"+aby.Text+"','"+vc.Text+"','"+vrn.Text+"')";
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
            License_Type license_Type = new License_Type();
            license_Type.ShowDialog();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Interface mainWindow = new Interface();
            mainWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pno.Clear();
            fn.Clear();
            age.Clear();
            hei.Clear();
            bl.Clear();
            add.Clear();
            pn.Clear();
            aby.Clear();
            vc.Clear();
            vrn.Clear();
        }

        private void pno_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void hei_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void pn_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void vrn_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
