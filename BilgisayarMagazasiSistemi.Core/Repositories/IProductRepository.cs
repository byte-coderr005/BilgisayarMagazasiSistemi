using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgisayarMagazasiSistemi.Core.Entities; 

namespace BilgisayarMagazasiSistemi.Core.Repositories
{
   public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsInStockAsync();
    }
}
