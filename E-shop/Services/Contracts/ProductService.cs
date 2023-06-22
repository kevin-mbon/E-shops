using Eshop.Models.Dtos;
using System.Net.Http.Json;

namespace Eshop.Services.Contracts
{
    public class ProductService : IProductService
{
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/products");

                return products;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
