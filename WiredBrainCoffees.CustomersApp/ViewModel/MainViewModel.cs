﻿using System;
using System.Threading.Tasks;
using WiredBrainCoffees.CustomersApp.Command;

namespace WiredBrainCoffees.CustomersApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
       
        private ViewModelBase? _selectedViewModel;

		public MainViewModel(CustomersViewModel customersViewModel, ProductsViewModel productsViewModel)
		{
            CustomersViewModel = customersViewModel;
			ProductsViewModel = productsViewModel;
			SelectedViewModel = CustomersViewModel;
			SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }

        public ViewModelBase? SelectedViewModel
		{
			get => _selectedViewModel; 
			set
		    {
				_selectedViewModel = value;
				RaisePropertyChanged();
			}
		}
        public CustomersViewModel CustomersViewModel { get; }
        public ProductsViewModel ProductsViewModel { get; }

        public DelegateCommand SelectViewModelCommand { get;}

        public async override Task LoadAsync()
		{
			if(SelectedViewModel is not null)
			{
				await SelectedViewModel.LoadAsync();
			}
		}

        private async void SelectViewModel(object? parametr)
        {
			SelectedViewModel = parametr as ViewModelBase;
			await LoadAsync();
        }
    }
}
