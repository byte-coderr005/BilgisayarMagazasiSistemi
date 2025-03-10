using BilgisayarMagazasiSistemi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilgisayarMagazasiSistemi.Business.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task AddCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(int id);
    }
}
