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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CashWithdrawlButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPageAccountSelection();
        }

        private void DepositButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToDepositPageAccountSelection();
        }

        private void TransferButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPageFromAccountSelection();
        }

        private void AccountBalancesButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToAccountBalancesSelectionScreen();
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToLogin();
        }
    }
}
