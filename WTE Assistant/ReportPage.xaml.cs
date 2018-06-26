using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WTE_Assistant
{
    /// <summary>
    /// ReportPage.xaml 的交互逻辑
    /// </summary>
    public partial class ReportPage : Window
    {
        public List<IntegrationDllResult> IntegrationDllResults { get; set; }

        public ReportPage()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //List<IntegrationDllResult> results = new List<IntegrationDllResult>
            //{
            //    new IntegrationDllResult
            //    {
            //        DllName = "1dll",
            //TotalTestNum = 456,
            //PassedTestNum = 356,
            //FailedTestNum = 102,
            //DllPath = "123",
            //NotExecutedTestNum = 12,
            //TestResults = null,
            //FailedTestResults = null
            //    }

            //};

            this.dllDataGrid.ItemsSource = IntegrationDllResults;
        }

        private void dllDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IntegrationDllResult integrationDllResult = this.dllDataGrid.SelectedItem as IntegrationDllResult;
            this.testDataGrid.ItemsSource = integrationDllResult.TestResults;
        }

        private void testDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
