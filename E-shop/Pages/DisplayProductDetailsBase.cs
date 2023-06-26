using Eshop.Models.Dtos;
using Eshop.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Eshop.Pages
{
    public class DisplayProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }

        public ProductDto Product { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductService.GetItem(Id);

            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;


            }
        }
    }
}
