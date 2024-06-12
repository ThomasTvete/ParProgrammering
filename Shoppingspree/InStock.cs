using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class InStock
    {
        public List<InventoryItem> StockList;

        public InStock()
        {
            StockList = new List<InventoryItem>();
        }

        public void AddStock(InventoryItem item)
        {
            StockList.Add(item);
        }
    }
}
