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
    /// Interaction logic for TransferPageToAccountSelection.xaml
    /// </summary>
    public partial class TransferPageToAccountSelection : UserControl
    {
        public TransferPageToAccountSelection()
        {
            InitializeComponent();
        }
        private void TransferToChequingButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPage(Account.AccountType.Chequings);
        }

        private void TransferToSavingsButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPage(Account.AccountType.Savings);
        }

        private void TransferToCreditCardButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPage(Account.AccountType.Creditcard);
        }

        private void TransferToCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }
    }
}
