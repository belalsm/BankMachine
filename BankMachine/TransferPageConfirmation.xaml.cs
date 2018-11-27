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
    /// Interaction logic for TransferPageConfirmation.xaml
    /// </summary>
    public partial class TransferPageConfirmation : UserControl, INotifyPropertyChanged
    {

        public int amount;
        public string fromAccountType;
        public Account.AccountType fromTypeEnum;
        public string toAccountType;
        public Account.AccountType toTypeEnum;

        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value; NotifyPropertyChanged("Amount");
            }
        }

        public string FromAccountType
        {
            get { return fromAccountType; }
            set
            {
                fromAccountType = value; NotifyPropertyChanged("FromAccountType");
            }
        }

        public string ToAccountType
        {
            get { return toAccountType; }
            set
            {
                toAccountType = value; NotifyPropertyChanged("ToAccountType");
            }
        }

        public TransferPageConfirmation()
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

        private void ConfirmTransferAmountChangeButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToTransferPage(MainWindow.to);
        }

        private void ConfirmTransferAmountCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }

        private void ConfirmTransferAmountOkButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCompleteTransactionsPage();
        }
    }
}
