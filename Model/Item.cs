using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobCalculator.Model
{
    public class Item
    {
        public string Name { get; set; }
        public bool SaleTaxExempt { get; set; }
        public decimal  Price{ get; set; }
       
    }
}
