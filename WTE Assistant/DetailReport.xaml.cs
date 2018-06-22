using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

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
            this.summaryDataGrid.ItemsSource = IntegrationDllResults;
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

        private void Maximization_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void summaryDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            IntegrationDllResult integrationDllResult = this.summaryDataGrid.SelectedItem as IntegrationDllResult;
            this.detailsDataGrid.ItemsSource = integrationDllResult.FailedTestResults;
        }
    }
}
