using Boilerplate_Microservice_WebAPI.Models;

namespace Boilerplate_Microservice_WebAPI.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        void InsertProduct (Product product);
        void DeleteProduct (int productId);
        void UpdateProduct (Product product);
        void Save();
    }
}
