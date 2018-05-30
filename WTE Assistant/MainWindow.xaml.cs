using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using MaterialDesignThemes.Wpf;

namespace WTE_Assistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static MainWindow main;
        internal double ResetProgressValue
        {
            get { return this.ResetProgress.Value; }
            set
            {
                Dispatcher.Invoke(new Action(() => { this.ResetProgress.Value = value; }));
            }
        }
        internal string DllNameValue
        {
            get { return this.DllName.Content.ToString(); }
            set
            {
                Dispatcher.Invoke(new Action(() => { this.DllName.Content = value; }));
            }
        }
        internal string DllResultsValue
        {
            get { return this.DllResults.Content.ToString(); }
            set
            {
                Dispatcher.Invoke(new Action(() => { this.DllResults.Content = value; }));
            }
        }
        internal string RunningTestValue
        {
            get { return this.RunningTest.Content.ToString(); }
            set
            {
                Dispatcher.Invoke(new Action(() => { this.RunningTest.Content = value; }));
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            main = this;
            this.ResetProgress.Visibility = Visibility.Hidden;
            this.DllName.Visibility = Visibility.Hidden;
            this.DllResults.Visibility = Visibility.Hidden;
            this.RunningTest.Visibility = Visibility.Hidden;
            this.VSLocation.Text = @"D:\Program Files (x86)\Microsoft Visual Studio 15.0";
        }

        private void ColorZone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void WindowClose(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int ResetTime = Int32.Parse(this.ResetTime.Text);
            string VSLocation = this.VSLocation.Text;

            if (Directory.Exists(VSLocation) && File.Exists(VSLocation + "\\Common7\\IDE\\devenv.exe"))
            {
                this.StartButton.Content = "RUNNING";
                this.StartButton.FontSize = 18;
                //this.StartButton.Foreground = Brushes.Yellow;
                //this.StartButton.Background = Brushes.MidnightBlue;
                this.StartButton.IsEnabled = false;

                WTEHelper WTEHelper = new WTEHelper(ResetTime, VSLocation);
                Thread T1 = new Thread(WTEHelper.Start);
                T1.IsBackground = true;
                T1.Start();                
            }
            else
            {
                ErrorPage errorPage = new ErrorPage();
                errorPage.Show();
            }

        }
    }
}
