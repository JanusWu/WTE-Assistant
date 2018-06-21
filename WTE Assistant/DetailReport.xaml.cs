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
using System.Windows.Shapes;

namespace WTE_Assistant
{
    /// <summary>
    /// Interaction logic for DetailReport.xaml
    /// </summary>
    public partial class DetailReport : Window
    {
        public List<IntegrationDllResult> IntegrationDllResults { get; set; }

        public DetailReport()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.summaryDataGrid.ItemsSource = IntegrationDllResults;
            //this.ResultsSummary.ItemsSource = IntegrationDllResults;
        }

        private void ColorZone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
