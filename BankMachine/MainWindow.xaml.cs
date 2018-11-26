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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
        public static void ChangeToAccountBalancesScreen()
        {
            main.Content = accountBalances;
        }
        public static void ChangeToAccountBalancesSelectionScreen()
        {
            main.Content = accountBalancesAccountSelection;
        }
        public static void ChangeToCashWithdrawlPage()
        {
            main.Content = cashWithdrawlPage;
        }
        public static void ChangeToCashWithdrawlPageAccountSelection()
        {
            main.Content = cashWithdrawlPageAccountSelection;
        }
        public static void ChangeToCashWithdrawlPageConfirmation()
        {
            main.Content = cashWithdrawlPageConfirmation;
        }
        public static void ChangeToCompleteTransactionsPage()
        {
            main.Content = completeTransactionsPage;
        }
        public static void ChangeToDepositPage()
        {
            main.Content = depositPage;
        }
        public static void ChangeToDepositPageAccountSelection()
        {
            main.Content = depositPageAccountSelection;
        }
        public static void ChangeToDepositPageConfirmation()
        {
            main.Content = depositPageConfirmation;
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
        public static void ChangeToTransferPage()
        {
            main.Content = transferPage;
        }
        public static void ChangeToTransferPageConfirmation()
        {
            main.Content = transferPageConfirmation;
        }
        public static void ChangeToTransferPageFromAccountSelection()
        {
            main.Content = transferPageFromAccountSelection;
        }
        public static void ChangeToTransferPageToAccountSelection()
        {
            main.Content = transferPageToAccountSelection;
        }


    }
}
