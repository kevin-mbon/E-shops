using Shop.api.Entities;
using Shop.api.Repositories.Contracts;

namespace Shop.api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<ProductCategory>> GetCategpries()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetCategpries(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItem()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
