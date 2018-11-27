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
    /// Interaction logic for CashWithdrawlPageConfirmation.xaml
    /// </summary>
    public partial class CashWithdrawlPageConfirmation : UserControl, INotifyPropertyChanged
    {
        public int amount;
        public string accountType;
        public Account.AccountType typeEnum;

        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value; NotifyPropertyChanged("Amount");
            }
        }

        public string AccountType
        {
            get { return accountType; }
            set
            {
                accountType = value; NotifyPropertyChanged("AccountType");
            }
        }

        public CashWithdrawlPageConfirmation()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        private void ConfirmWithdrawlAmountChangeButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPage(MainWindow.from);
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
