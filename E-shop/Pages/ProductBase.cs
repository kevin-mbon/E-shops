﻿using Eshop.Models.Dtos;
using Eshop.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.Linq;

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
        protected IOrderedEnumerable<IGrouping<int,ProductDto>> GetGroupedProductsByCategory() { 
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }
        protected string GetCategoryName()
        {


        }
    }
}
