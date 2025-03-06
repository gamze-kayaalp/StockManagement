using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokYönetimi.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public decimal Price { get; set; }
    }
}
