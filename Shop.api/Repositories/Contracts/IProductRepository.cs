using Shop.api.Entities;

namespace Shop.api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<Product> GetItem(int id);
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<IEnumerable<Product>> GetItems();
        Task<Product> GetCategory(int id);
    } 
}
