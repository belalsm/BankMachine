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
    /// Interaction logic for TransferPageFromAccountSelection.xaml
    /// </summary>
    public partial class TransferPageFromAccountSelection : UserControl
    {
        public TransferPageFromAccountSelection()
        {
            InitializeComponent();
        }

        private void TransferFromChequingButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPageToAccountSelection(Account.AccountType.Chequings);
        }

        private void TransferFromSavingsButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPageToAccountSelection(Account.AccountType.Savings);
        }

        private void TransferFromCreditCardButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPageToAccountSelection(Account.AccountType.Creditcard);
        }

        private void TransferFromCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }
    }
}
