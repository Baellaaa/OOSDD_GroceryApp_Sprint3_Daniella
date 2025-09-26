using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IProductService
    {
        public List<Product> GetAll();

        public Product Add(Product item);

        public Product? Delete(Product item);

        public Product? Get(int id);

        public Product? Update(Product item);

        public List<Product> Search(string productName);
    }
}
