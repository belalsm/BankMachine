﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public static int amount = 0;
        public static Account.AccountType from;
        public static Account.AccountType to;
        public static Account.AccountTransaction currentTransaction;
        public static int accountNumber = 0;
        public static int pin = 0;
        public static int chequingBalance = 100;
        public static int savingsBalance = 100;
        public static int creditCardBalance = 100;
        public static Account account = new Account();
        public static ContentControl main;
        public static AccountBalances accountBalances = new AccountBalances();
        public static AccountBalancesAccountSelection accountBalancesAccountSelection = new AccountBalancesAccountSelection();
        public static CashWithdrawlPage cashWithdrawlPage = new CashWithdrawlPage();
        public static CashWithdrawlPageAccountSelection cashWithdrawlPageAccountSelection = new CashWithdrawlPageAccountSelection();
        public static CashWithdrawlPageConfirmation cashWithdrawlPageConfirmation = new CashWithdrawlPageConfirmation();
        public static CompleteTransactionsPage completeTransactionsPage = new CompleteTransactionsPage();
        public static DepositPage depositPage = new DepositPage();
        public static DepositPageAccountSelection depositPageAccountSelection = new DepositPageAccountSelection();
        public static DepositPageConfirmation depositPageConfirmation = new DepositPageConfirmation();
        public static EnterAccountInfoPage enterAccountInfoPage = new EnterAccountInfoPage();
        public static Login login = new Login();
        public static MainPage mainPage = new MainPage();
        public static ScanCardPage scanCardPage = new ScanCardPage();
        public static TransferPage transferPage = new TransferPage();
        public static TransferPageConfirmation transferPageConfirmation = new TransferPageConfirmation();
        public static TransferPageFromAccountSelection transferPageFromAccountSelection = new TransferPageFromAccountSelection();
        public static TransferPageToAccountSelection transferPageToAccountSelection = new TransferPageToAccountSelection();
        public MainWindow()
        {
            InitializeComponent();
            main = ContentMain;
            main.Content = login;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        public static void ChangeToAccountBalancesScreen(Account.AccountType selectedAccount)
        {
            from = selectedAccount;
            if (selectedAccount == Account.AccountType.Chequings) {
                accountBalances.Balance = chequingBalance;
                accountBalances.AccountType = Account.AccountType.Chequings.ToString();
            }
            if (selectedAccount == Account.AccountType.Savings) {
                accountBalances.Balance = savingsBalance;
                accountBalances.AccountType = Account.AccountType.Savings.ToString();
            }
            if (selectedAccount == Account.AccountType.Creditcard) {
                accountBalances.Balance = creditCardBalance;
                accountBalances.AccountType = Account.AccountType.Creditcard.ToString();
            }
            main.Content = accountBalances;
        }
        public static void ChangeToAccountBalancesSelectionScreen()
        {
            main.Content = accountBalancesAccountSelection;
        }
        public static void ChangeToCashWithdrawlPage(Account.AccountType fromAccount)
        {
            from = fromAccount;
            cashWithdrawlPage.Amount = 0;
            main.Content = cashWithdrawlPage;
        }
        public static void ChangeToCashWithdrawlPageAccountSelection()
        {
            main.Content = cashWithdrawlPageAccountSelection;
        }
        public static void ChangeToCashWithdrawlPageConfirmation(int withdrawAmount)
        {
            amount = withdrawAmount;
            cashWithdrawlPageConfirmation.Amount = amount;
            cashWithdrawlPageConfirmation.AccountType = from.ToString();
            cashWithdrawlPageConfirmation.typeEnum = from;
            main.Content = cashWithdrawlPageConfirmation;
            currentTransaction = Account.AccountTransaction.Withdraw;
        }
        public static void ChangeToCompleteTransactionsPage()
        {
            if(currentTransaction == Account.AccountTransaction.Withdraw)
            {
                Withdraw(from, amount);
            }
            if (currentTransaction == Account.AccountTransaction.Deposit)
            {
                Deposit(to, amount);
            }
            if (currentTransaction == Account.AccountTransaction.Transfer)
            {
                transferPageToAccountSelection.ToChequing.IsEnabled = true;
                transferPageToAccountSelection.ToCreditCard.IsEnabled = true;
                transferPageToAccountSelection.ToSavings.IsEnabled = true;
                Transfer(from, to, amount);
            }

            amount = 0;
            main.Content = completeTransactionsPage;
        }
        public static void ChangeToDepositPage(Account.AccountType toAccount)
        {
            to = toAccount;
            depositPage.Amount = 0;
            main.Content = depositPage;
        }
        public static void ChangeToDepositPageAccountSelection()
        {
            main.Content = depositPageAccountSelection;
        }
        public static void ChangeToDepositPageConfirmation(int depositAmount)
        {
            amount = depositAmount;
            depositPageConfirmation.Amount = amount;
            depositPageConfirmation.AccountType = to.ToString();
            depositPageConfirmation.typeEnum = to;
            main.Content = depositPageConfirmation;
            currentTransaction = Account.AccountTransaction.Deposit;

        }
        public static void ChangeToEnterAccountInfoPage()
        {
            main.Content = enterAccountInfoPage;
        }
        public static void ChangeToLogin()
        {
            main.Content = login;
        }
        public static void ChangeToMainPage()
        {
            main.Content = mainPage;
        }
        public static void ChangeToScanScreen()
        {
            main.Content = scanCardPage;
        }
        public static void ChangeToTransferPage(Account.AccountType toAccount)
        {
            to = toAccount;
            transferPage.Amount = 0;
            main.Content = transferPage;
        }
        public static void ChangeToTransferPageConfirmation(int transferAmount)
        {
            amount = transferAmount;
            transferPageConfirmation.Amount = amount;
            transferPageConfirmation.FromAccountType = from.ToString();
            transferPageConfirmation.fromTypeEnum = from;
            transferPageConfirmation.ToAccountType = to.ToString();
            transferPageConfirmation.toTypeEnum = to;
            main.Content = transferPageConfirmation;
            currentTransaction = Account.AccountTransaction.Transfer;

        }
        public static void ChangeToTransferPageFromAccountSelection()
        {
            main.Content = transferPageFromAccountSelection;
        }
        public static void ChangeToTransferPageToAccountSelection(Account.AccountType fromAccount)
        {
            from = fromAccount;
            if (from == Account.AccountType.Chequings) { transferPageToAccountSelection.ToChequing.IsEnabled = false; }
            if (from == Account.AccountType.Savings) { transferPageToAccountSelection.ToSavings.IsEnabled = false; }
            if (from == Account.AccountType.Creditcard) { transferPageToAccountSelection.ToCreditCard.IsEnabled = false; }
            main.Content = transferPageToAccountSelection;
        }

        public static void Transfer(Account.AccountType accountFrom, Account.AccountType accountTo, int amount)
        {

            if (accountFrom == Account.AccountType.Chequings && accountTo == Account.AccountType.Creditcard) { chequingBalance -= amount; creditCardBalance += amount; }
            if (accountFrom == Account.AccountType.Chequings && accountTo == Account.AccountType.Savings) { chequingBalance -= amount; savingsBalance += amount; }

            if (accountFrom == Account.AccountType.Creditcard && accountTo == Account.AccountType.Chequings) { creditCardBalance -= amount; chequingBalance += amount; }
            if (accountFrom == Account.AccountType.Creditcard && accountTo == Account.AccountType.Savings) { creditCardBalance -= amount; savingsBalance += amount; }

            if (accountFrom == Account.AccountType.Savings && accountTo == Account.AccountType.Creditcard) { savingsBalance -= amount; creditCardBalance += amount; }
            if (accountFrom == Account.AccountType.Savings && accountTo == Account.AccountType.Chequings) { savingsBalance -= amount; chequingBalance += amount; }

        }

        public static void Deposit(Account.AccountType accountTo, int amount)
        {
            if (accountTo == Account.AccountType.Chequings) { chequingBalance += amount; }
            if (accountTo == Account.AccountType.Creditcard) { creditCardBalance += amount; }
            if (accountTo == Account.AccountType.Savings) { savingsBalance += amount; }
        }

        public static void Withdraw(Account.AccountType accountFrom, int amount)
        {
            if (accountFrom == Account.AccountType.Chequings) { chequingBalance -= amount; }
            if (accountFrom == Account.AccountType.Creditcard) { creditCardBalance -= amount; }
            if (accountFrom == Account.AccountType.Savings) { savingsBalance -= amount; }
        }


    }
}
