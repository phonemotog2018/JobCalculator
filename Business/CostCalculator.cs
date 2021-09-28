using JobCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobCalculator.Business
{
    public class CostCalculator: ICostCalculator
    {

        public Result CalculateJobCost(JobDTO job)
        {
            var items = new List<Item>();
            var total = 0M;
            foreach (var item in job.Items)
            {
                Item updatedItem = GetUpdatedItem(item);
                items.Add(updatedItem);
                total += updatedItem.Price;
            }

            total += CalculateMargin(total, job.ExtraMargin);

            var result = new Result
            {
                Items = items,
                Total = total
            };

            return result;
        }

        Item GetUpdatedItem(Item item)
        {
            decimal updatedPrice = item.Price;
            if (!item.SaleTaxExempt)
            {
                updatedPrice = CalculateSalesTax(item.Price);
            }
            var updatedItem = new Item
            {
                Name = item.Name,
                Price = updatedPrice
            };

            return updatedItem;
        }

      public decimal CalculateMargin(decimal price, bool extraMargin = false) => extraMargin ? 16 % price : 11 % price;

      public decimal CalculateSalesTax(decimal price) => price + 7 % price;
     

    }
}
