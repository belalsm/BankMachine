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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankMachine
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterAccountNumber(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToEnterAccountInfoPage();
        }
        private void ScanCard(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToScanScreen();
        }
    }
}
