using Eshop.Models.Dtos;
using Shop.api.Entities;

namespace Shop.api.Repositories.Contracts
{
    public interface IShoppingCart
    {
        Task<CartItems> AddItem(CartItemToAddDto cartItemToAddDtos);
        Task<CartItems> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto);
        Task<CartItems> DeleteItem(int id);
        Task<CartItems> GetItem(int id);
        Task<IEnumerable<CartItems>> GetItems(int UserId);
     }
}
