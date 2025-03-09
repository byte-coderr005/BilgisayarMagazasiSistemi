using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarMagazasiSistemi.Core.Entities
{
   public class Laptop : Product
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

    }
}
