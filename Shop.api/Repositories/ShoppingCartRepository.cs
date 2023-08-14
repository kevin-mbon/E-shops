using Eshop.Models.Dtos;
using Microsoft.EntityFrameworkCore;
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
        public async Task<bool> CartItemExists(int cartId,int productId)
        {
            return await this.eshopDbntext.CartItems.AnyAsync( c => c.CartId == cartId && c.ProductId == productId );
        }
        public async Task<CartItems> AddItem(CartItemToAddDto cartItemToAddDtos)
        {
            if(await CartItemExists(cartItemToAddDtos.ProductId,cartItemToAddDtos.CartId) == false)
            {
                var item = await (
              from product in this.eshopDbntext.Products
              where product.Id == cartItemToAddDtos.ProductId
              select new CartItems
              {
                  CartId = cartItemToAddDtos.CartId,
                  ProductId = product.Id,
                  Qty = cartItemToAddDtos.Qty,
              }).SingleOrDefaultAsync();
                if (item != null) {
                    var result = await this.eshopDbntext.CartItems.AddAsync(item);
                    await this.eshopDbntext.SaveChangesAsync();
                    return result.Entity;
                }
          
            }
            return null;

        }

        public Task<CartItems> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CartItems> GetItem(int id)
        {
            return await (from cart in this.eshopDbntext.Carts
                          join cartItem in this.eshopDbntext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItems
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();


        }

        public async Task<IEnumerable<CartItems>> GetItems(int UserId)
        {
            return await (from cart in this.eshopDbntext.Carts
                          join cartItem in this.eshopDbntext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == UserId
                          select new CartItems
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId =cartItem.CartId
                          }).ToListAsync();



        }

        public Task<CartItems> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
