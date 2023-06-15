using Shop.api.Entities;

namespace Shop.api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<IEnumerable<Product>> GetItems(int id);
        Task<IEnumerable<Product>> GetCategpries(int id);
    } 
}
