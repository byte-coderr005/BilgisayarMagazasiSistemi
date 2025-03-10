using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgisayarMagazasiSistemi.Core.Entities;
using BilgisayarMagazasiSistemi.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BilgisayarMagazasiSistemi.Data.Access.Repositories
{
   public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly BilgisayarContext _context;

        public ProductRepository(BilgisayarContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsInStockAsync()
        {
            return await _context.Products.Where(p => p.Stock > 0).ToListAsync();
        }
    }
}
