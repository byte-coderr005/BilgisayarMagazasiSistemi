﻿using BilgisayarMagazasiSistemi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BilgisayarMagazasiSistemi.Business.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
