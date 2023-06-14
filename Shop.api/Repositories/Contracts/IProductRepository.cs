using Shop.api.Entities;

namespace Shop.api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItem();
        Task<IEnumerable<ProductCategory>> GetCategpries();
        Task<IEnumerable<Product>> GetItem(int id);
        Task<IEnumerable<Product>> GetCategpries(int id);
    } 
}
