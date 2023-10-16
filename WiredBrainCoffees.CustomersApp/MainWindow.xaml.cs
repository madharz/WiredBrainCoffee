using System;
using System.Windows;
using WiredBrainCoffees.CustomersApp.Data;
using WiredBrainCoffees.CustomersApp.ViewModel;

namespace WiredBrainCoffees.CustomersApp
{

    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vievModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _vievModel = viewModel ;
            DataContext = _vievModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _vievModel.LoadAsync();
        }
    }
}
