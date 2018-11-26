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
        public static bool scanScreen = false; //This must be public and static so that it can be called from your second Window
        public static ContentControl main;
        Login login = new Login();
        public static ScanCardPage scanCardPage = new ScanCardPage();
        public MainWindow()
        {
            InitializeComponent();
            main = ContentMain;
            main.Content = login;
        }
        public static void ChangeToScanScreen()
        {
            main.Content = scanCardPage;
        }


    }
}
