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
    /// Interaction logic for DepositPageAccountSelection.xaml
    /// </summary>
    public partial class DepositPageAccountSelection : UserControl
    {
        public DepositPageAccountSelection()
        {
            InitializeComponent();
        }


        private void DepositToChequingButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToDepositPage();
        }

        private void DepositToSavingsButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToDepositPage();
        }

        private void DepositToCreditCardButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToDepositPage();
        }

        private void DepositCancelButton(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeToMainPage();
        }
    }
}
