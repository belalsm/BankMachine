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
        Login login = new Login();
        ScanCardPage scanCardPage = new ScanCardPage();
        public MainWindow()
        {
            InitializeComponent();

            ContentMain.Content = login;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer(); //Initialize a new timer object
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick); //Link the Tick event with dispatcherTimer_Tick
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1); //Set the Timer Interval
            dispatcherTimer.Start(); //Start the Timer
        }
        public void ChangeToScanScreen()
        {
            ContentMain.Content = scanCardPage;
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (scanScreen)
            {
                scanScreen = false;
                ChangeToScanScreen();
            }
        }


    }
}
