using stokYönetimi.DataAccess;
using stokYönetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokYönetimi.Business
{
    public class ProductManager
    {
        private ProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public void UpdateStock(int productId, int newQuantity)
        {
            _productRepository.UpdateStock(productId, newQuantity);
        }

        public List<Product> GetLowStockProducts()
        {
            return _productRepository.GetLowStockProducts();
        }
    }
}
