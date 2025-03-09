using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarMagazasiSistemi.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalPrice => CalculateTotalPrice();
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
