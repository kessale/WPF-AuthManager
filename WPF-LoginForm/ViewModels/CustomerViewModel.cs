using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MySql.Data.MySqlClient;
using WPF_LoginForm.Models;
using WPF_LoginForm.Repositories;
using WPF_LoginForm.ViewModels;
using WPF_LoginForm.Views;

namespace WPF_LoginForm.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        private ObservableCollection<Customer> _customers;
        private ObservableCollection<Customer> _originalCustomers;



        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }




        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
                Search(); // Вызывать поиск при изменении текста
            }
        }
        private string _searchText;



        public CustomerViewModel()
        {

            LoadData();
            
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost; Database=MVVMLoginDb; Uid=root; Pwd=mySQLlocal;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Customer FROM Customers";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string customerName = reader.GetString(1);

                        customers.Add(new Customer { Id = id, CustomerName = customerName });
                    }

                    Customers = customers;
                    _originalCustomers = new ObservableCollection<Customer>(Customers);
                }
            }
        }



        private void Search()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                Customers = new ObservableCollection<Customer>(_originalCustomers);
            }
            else
            {
                var filteredCustomers = _originalCustomers
                    .Where(c => c.CustomerName.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                Customers = new ObservableCollection<Customer>(filteredCustomers);
            }
        }


        private ViewModelCommand addCommand;

        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new ViewModelCommand(Add1);
                }

                return addCommand;
            }
        }

        private void Add1(object commandParameter)
        {
        }



    }
}
