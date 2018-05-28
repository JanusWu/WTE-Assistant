using System;
using System.Collections.Generic;
using System.IO;
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
using MaterialDesignThemes.Wpf;

namespace WTE_Assistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ResetProgress.Visibility = Visibility.Hidden;
            this.DllInfor.Visibility = Visibility.Hidden;
            this.Results.Visibility = Visibility.Hidden;
            this.Running.Visibility = Visibility.Hidden;
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

            if (Directory.Exists(VSLocation) && File.Exists(VSLocation+ "\\Common7\\IDE\\devenv.exe"))
            {
                WTEHelper WTEHelper = new WTEHelper(ResetTime, VSLocation);
                WTEHelper.Start();
            }
            else
            {
                ErrorPage errorPage = new ErrorPage();
                errorPage.Show();
            }

        }
    }
}
