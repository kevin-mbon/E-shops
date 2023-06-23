using Eshop.Models.Dtos;
using Eshop.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Eshop.Pages
{
    public class ProductBase : ComponentBase
{
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
