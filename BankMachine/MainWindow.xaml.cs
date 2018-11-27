using System;
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
            if (selectedAccount == Account.AccountType.chequings) {
                accountBalances.Balance = chequingBalance;
                accountBalances.AccountType = Account.AccountType.chequings.ToString();
            }
            if (selectedAccount == Account.AccountType.savings) {
                accountBalances.Balance = savingsBalance;
                accountBalances.AccountType = Account.AccountType.savings.ToString();
            }
            if (selectedAccount == Account.AccountType.creditcard) {
                accountBalances.Balance = creditCardBalance;
                accountBalances.AccountType = Account.AccountType.creditcard.ToString();
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
            main.Content = transferPageToAccountSelection;
        }

        public static void Transfer(Account.AccountType accountFrom, Account.AccountType accountTo, int amount)
        {

            if (accountFrom == Account.AccountType.chequings && accountTo == Account.AccountType.creditcard) { chequingBalance -= amount; creditCardBalance += amount; }
            if (accountFrom == Account.AccountType.chequings && accountTo == Account.AccountType.savings) { chequingBalance -= amount; savingsBalance += amount; }

            if (accountFrom == Account.AccountType.creditcard && accountTo == Account.AccountType.chequings) { creditCardBalance -= amount; chequingBalance += amount; }
            if (accountFrom == Account.AccountType.creditcard && accountTo == Account.AccountType.savings) { creditCardBalance -= amount; savingsBalance += amount; }

            if (accountFrom == Account.AccountType.savings && accountTo == Account.AccountType.creditcard) { savingsBalance -= amount; creditCardBalance += amount; }
            if (accountFrom == Account.AccountType.savings && accountTo == Account.AccountType.chequings) { savingsBalance -= amount; chequingBalance += amount; }

        }

        public static void Deposit(Account.AccountType accountTo, int amount)
        {
            if (accountTo == Account.AccountType.chequings) { chequingBalance += amount; }
            if (accountTo == Account.AccountType.creditcard) { creditCardBalance += amount; }
            if (accountTo == Account.AccountType.savings) { savingsBalance += amount; }
        }

        public static void Withdraw(Account.AccountType accountFrom, int amount)
        {
            if (accountFrom == Account.AccountType.chequings) { chequingBalance -= amount; }
            if (accountFrom == Account.AccountType.creditcard) { creditCardBalance -= amount; }
            if (accountFrom == Account.AccountType.savings) { savingsBalance -= amount; }
        }


    }
}
