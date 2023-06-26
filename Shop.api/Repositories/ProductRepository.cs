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

        public async Task<ProductCategory > GetCategory(int id)
        {
           var category = await this.eshopDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await this.eshopDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.eshopDbContext.Products.ToListAsync();
            return products;
        }

       
    }
}
