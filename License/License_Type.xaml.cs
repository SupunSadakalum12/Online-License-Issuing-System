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
    /// Interaction logic for License_Type.xaml
    /// </summary>
    public partial class License_Type : Window
    {
        string a;
        public License_Type()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (r1.IsChecked == true)
            {
                a = "A1";
            }
            else if (r2.IsChecked == true)
            {
                a = "A";
            }
            else if(r3.IsChecked == true)
            {
                a = "B1";
            }
            else if (r4.IsChecked == true)
            {
                a = "B";
            }
            else if (r5.IsChecked == true)
            {
                a = "C1";
            }
            else if (r6.IsChecked == true)
            {
                a = "C";
            }
            else if (r7.IsChecked == true)
            {
                a = "CE";
            }
            else if (r8.IsChecked == true)
            {
                a = "D1";
            }
            else if (r9.IsChecked == true)
            {
                a = "D";
            }
            else if (r10.IsChecked == true)
            {
                a = "DE";
            }
            else if (r11.IsChecked == true)
            {
                a = "G1";
            }
            else if (r12.IsChecked == true)
            {
                a = "G";
            }
            else
            {
                a = "J";
            }
            string query = "INSERT INTO `select license type`(`License Type`) VALUES ('"+a+"')";
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
            Verification verification = new Verification();
            verification.ShowDialog();
            Close();
        }
    }
}
