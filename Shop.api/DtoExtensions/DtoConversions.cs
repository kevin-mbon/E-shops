using Eshop.Models.Dtos;
using Shop.api.Entities;

namespace Shop.api.DtoExtensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories )
        {
            return (from product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImgUrl = product.ImgUrl,
                        Price = product.Price,
                        Qty = product.Qty,
                        CategoryId = product.CategoryId
                    }).ToList();
                    

    }
    }
}
