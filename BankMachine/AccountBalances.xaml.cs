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
    /// Interaction logic for AccountBalances.xaml
    /// </summary>
    public partial class AccountBalances : UserControl
    {
        public AccountBalances()
        {
            InitializeComponent();
        }


        private void AccountBalancesCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }

        private void AccountBalancesOkButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCompleteTransactionsPage();
        }
    }
}
