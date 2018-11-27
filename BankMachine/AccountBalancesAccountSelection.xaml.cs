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
    /// Interaction logic for AccountBalancesAccountSelection.xaml
    /// </summary>
    public partial class AccountBalancesAccountSelection : UserControl
    {
        public AccountBalancesAccountSelection()
        {
            InitializeComponent();
        }

        private void BalanceForChequingButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToAccountBalancesScreen(Account.AccountType.chequings);
        }

        private void BalanceForSavingsButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToAccountBalancesScreen(Account.AccountType.savings);
        }

        private void BalanceForCreditCardButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToAccountBalancesScreen(Account.AccountType.creditcard);
        }

        private void BalanceCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }
    }
}
