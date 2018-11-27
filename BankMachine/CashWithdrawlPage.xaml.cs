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
    /// Interaction logic for CashWithdrawlPage.xaml
    /// </summary>
    public partial class CashWithdrawlPage : UserControl, INotifyPropertyChanged
    {
        public int amount = 0;

        public int Amount
        {
            get { return amount; }
            set { amount = value; NotifyPropertyChanged("Amount");
            }
        }

        public CashWithdrawlPage()
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

        private void EnterWithdrawlAmountCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }

        private void EnterWithdrawlAmountOkButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToCashWithdrawlPageConfirmation(Amount);
        }
    }
}
