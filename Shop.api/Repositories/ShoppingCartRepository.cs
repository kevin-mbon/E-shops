using Eshop.Models.Dtos;
using Shop.api.Data;
using Shop.api.Entities;
using Shop.api.Repositories.Contracts;

namespace Shop.api.Repositories
{
    public class ShoppingCartRepository : IShoppingCart
    {
        private readonly EshopDbContext eshopDbntext;

        public ShoppingCartRepository(EshopDbContext eshopDbntext)
        {
            this.eshopDbntext = eshopDbntext;
        }
        public Task<CartItems> AddItem(CartItemToAddDto cartItemToAddDtos)
        {
            throw new NotImplementedException();
        }

        public Task<CartItems> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CartItems> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItems>> GetItems(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<CartItems> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
