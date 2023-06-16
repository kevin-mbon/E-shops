using Shop.api.Entities;

namespace Shop.api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItem(int id);
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<Product>> GetCategories(int id);
    } 
}
