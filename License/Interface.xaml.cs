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

namespace License
{
    /// <summary>
    /// Interaction logic for Interface.xaml
    /// </summary>
    public partial class Interface : Window
    {
        public Interface()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Application application = new Application();
            application.ShowDialog();
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            About_Us about_Us = new About_Us();
            about_Us.ShowDialog();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            Contact_Us contact_Us = new Contact_Us();
            contact_Us.ShowDialog();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to LOGOUT?", "LogOut", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Close the window
                Close();
            }
            else
            {
                // Do not close the window  
            }

        }
    }
}
