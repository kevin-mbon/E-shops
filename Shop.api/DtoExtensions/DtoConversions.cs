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
                        CategoryId = product.CategoryId,
                        CategoryName = product.CategoryName
                    }).ToList();
        }

        public static ProductDto ConvertToDto(this Product product, ProductCategory productCategory)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImgUrl = product.ImgUrl,
                Price = product.Price,
                Qty = product.Qty,
                CategoryId = product.CategoryId,
                CategoryName = product.CategoryName

            };
        }
        public static IEnumerable<CartItemDto> ConvertToDto(this IEnumerable<CartItems> cartItems, IEnumerable<Product> products)
        {
            return (from cartItem in cartItems
                    join product in products
                    on cartItem.ProductId equals product.Id
                    select new CartItemDto
                    {
                        Id = cartItem.Id,
                        ProductId = cartItem.ProductId,
                        Name = product.Name,
                        ImgUrl = product.ImgUrl,
                        ProductDescription = product.Description,
                        CartId = cartItem.CartId,
                        Qty = cartItem.Qty,
                        Price = product.Price,
                        TotalPrice = product.Price * cartItem.Qty
                    }).ToList();


        }
        public static CartItemDto ConvertToDto(this CartItems cartItem, Product product)
        {
            return  new CartItemDto
            {
                Id = cartItem.Id,
                ProductId = cartItem.ProductId,
                Name = product.Name,
                ImgUrl = product.ImgUrl,
                ProductDescription = product.Description,
                CartId = cartItem.CartId,
                Qty = cartItem.Qty,
                Price = product.Price,
                TotalPrice = product.Price * cartItem.Qty
            };



        }



    }
}
