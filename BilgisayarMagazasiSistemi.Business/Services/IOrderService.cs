using BilgisayarMagazasiSistemi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilgisayarMagazasiSistemi.Business.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
    }
}
