using Microsoft.EntityFrameworkCore;
using Shop.api.Data;
using Shop.api.Entities;
using Shop.api.Repositories.Contracts;

namespace Shop.api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EshopDbContext eshopDbContext;

        public ProductRepository(EshopDbContext eshopDbContext)
        {
            this.eshopDbContext = eshopDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
           var categories = await this.eshopDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<IEnumerable<Product>> GetCategories(int id)
        {
            throw new NotImplementedException(); 
        }

        public Task<IEnumerable<Product>> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.eshopDbContext.Products.ToListAsync();
            return products;
        }

       
    }
}
