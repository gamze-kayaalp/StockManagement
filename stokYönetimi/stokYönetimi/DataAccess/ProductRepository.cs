using stokYönetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokYönetimi.DataAccess
{
    public class ProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void UpdateStock(int productId, int newQuantity)
        {
            var product = _products.Find(p => p.ProductID == productId);
            if (product != null)
            {
                product.StockQuantity = newQuantity;
            }
        }

        public List<Product> GetLowStockProducts()
        {
            return _products.FindAll(p => p.StockQuantity <= p.ReorderLevel);
        }
    }
}
