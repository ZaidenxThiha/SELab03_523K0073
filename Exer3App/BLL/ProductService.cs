using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProductService
    {
        private readonly ProductRepository _repository = new ProductRepository();

        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }

        public Product GetProduct(int id)
        {
            return _repository.GetProductById(id);
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public void UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }
    }
}
