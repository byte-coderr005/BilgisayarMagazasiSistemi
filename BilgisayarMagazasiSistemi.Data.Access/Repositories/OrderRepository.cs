using BilgisayarMagazasiSistemi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgisayarMagazasiSistemi.Core.Repositories;  

namespace BilgisayarMagazasiSistemi.Data.Access.Repositories
{
  public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(BilgisayarContext context) : base(context) { }

    }
}
