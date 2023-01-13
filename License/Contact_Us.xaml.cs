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
    /// Interaction logic for Contact_Us.xaml
    /// </summary>
    public partial class Contact_Us : Window
    {
        public Contact_Us()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Interface mainWindow = new Interface();
            mainWindow.ShowDialog();
        }
    }
}
