using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCoffees.CustomersApp.Model;

namespace WiredBrainCoffees.CustomersApp.Data
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<Product>?>GetAllAsync();
    }
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(100);
            return new List<Product>
            {
                new Product{Name="Cappucciano",Description="Espresso with milk and milk foam"},
                new Product{Name="Doppio",Description="Double espresso"},
                new Product{Name="Espresso",Description="Pure coffee to keep you awake! :-)"},
                new Product{Name="Latte",Description="Cappucciano with more streamed milk"},
                new Product{Name="Macchiato",Description="Espresso with milk foam"},
                new Product{Name="Mocha",Description="Espresso with not chocolate and milk foam"}
            };
        }
    }
}
