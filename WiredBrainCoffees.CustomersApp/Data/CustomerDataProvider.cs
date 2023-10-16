using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffees.CustomersApp.Model;

namespace WiredBrainCoffees.CustomersApp.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }
    class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100); //Cимулиирует работу сервера
            return new List<Customer>
            {          
              new Customer{Id=1,FirstName="Julia",LastName="Developer",IsDeveloper=true},
              new Customer{Id=2,FirstName="Alex",LastName="Rider"},
              new Customer{Id=3,FirstName="Thomas Claudius",LastName="Developer",IsDeveloper=true},
              new Customer{Id=4,FirstName="Ann",LastName="Rockstar"},
              new Customer{Id=5,FirstName="Sara",LastName="Metroid"},
              new Customer{Id=6,FirstName="Ben",LastName="Ronaldo"},

             };
        }
    }
}
