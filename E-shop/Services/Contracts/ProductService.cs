using Eshop.Models.Dtos;

namespace Eshop.Services.Contracts
{
    public class ProductService : IProductService
{
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<IEnumerable<ProductDto>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
