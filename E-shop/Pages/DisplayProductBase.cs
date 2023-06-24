using Eshop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace Eshop.Pages
{
    public class DisplayProductBase : ComponentBase
{
        [Parameter]
        public IEnumerable<ProductDto>? Products { get; set; }
    }
}
