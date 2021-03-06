﻿using System;
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
    /// Interaction logic for CashWithdrawlPageAccountSelection.xaml
    /// </summary>
    public partial class CashWithdrawlPageAccountSelection : UserControl
    {
        public CashWithdrawlPageAccountSelection()
        {
            InitializeComponent();
        }

        private void WithdrawFromChequingButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPage(Account.AccountType.Chequings);

        }

        private void WithdrawFromSavingsButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPage(Account.AccountType.Savings);

        }
        
        private void WithdrawFromCreditCardButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPage(Account.AccountType.Creditcard);

        }

        private void WithdrawlCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }
    }
}
