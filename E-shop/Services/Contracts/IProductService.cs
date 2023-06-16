﻿using Eshop.Models.Dtos;

namespace Eshop.Services.Contracts
{
    public interface IProductService
{
        Task<IEnumerable<ProductDto>> GetItems();
       
}
}
