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
        public static bool ScanCardClickBool = false;
        public int test = 0;
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer(); //Initialize a new timer object
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick); //Link the Tick event with dispatcherTimer_Tick
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1); //Set the Timer Interval
            dispatcherTimer.Start(); //Start the Timer
            Login login = new Login();

            ContentMain.Content = login;
        }

        public void ScanCardClick()
        {
            test = 1;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (ScanCardClickBool)
            {
                ScanCardClickBool = false;
                ScanCardClick();
            }
        }


    }
}
