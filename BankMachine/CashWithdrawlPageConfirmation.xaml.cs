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
    /// Interaction logic for CashWithdrawlPageConfirmation.xaml
    /// </summary>
    public partial class CashWithdrawlPageConfirmation : UserControl
    {
        public CashWithdrawlPageConfirmation()
        {
            InitializeComponent();
        }

        private void ConfirmWithdrawlAmountChangeButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPage();
        }

        private void ConfirmWithdrawlAmountCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }

        private void ConfirmWithdrawlAmountOkButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCompleteTransactionsPage();
        }
    }
}
