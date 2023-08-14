using Eshop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.api.DtoExtensions;
using Shop.api.Repositories;
using Shop.api.Repositories.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace Shop.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IProductRepository productRepository;

        public ShoppingCartController(IShoppingCart shoppingCart, IProductRepository productRepository)
        {
            this.shoppingCart = shoppingCart;
            this.productRepository = productRepository;

        }

        [HttpGet]
        [Route("{userId}/GetItems")]
        public async Task<ActionResult<IEnumerable<CartItemToAddDto>>> GetItems(int userId)
        {
            try
            {
                var cartItems = await this.shoppingCart.GetItems(userId);
                if (cartItems == null)
                {
                    return NoContent();
                }
                var products = await this.productRepository.GetItems();
                if (products == null)
                {
                    throw new Exception("no product exist in system");
                }
                var cartItemDto = cartItems.ConvertToDto(products);
                return Ok(cartItemDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CartItemDto>> GetItem(int id)
        {
            try
            {
                var cartItem = await this.shoppingCart.GetItem(id);
                if(cartItem == null)
                {
                    return NotFound();

                }
                var product = await this.productRepository.GetItem(cartItem.ProductId);
                if (product == null)
                {
                    return NotFound();
                }
                var cartItemDto = cartItem.ConvertToDto(product);
                return Ok(cartItemDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<CartItemDto>> PostItem([FromBody] CartItemToAddDto itemToAddDto)
        {
            try
            {
                var newCartItem = await this.shoppingCart.AddItem(itemToAddDto);
                if (newCartItem == null)
                {
                    return NoContent();
                }
                var product = productRepository.GetItem(newCartItem.ProductId);
                if(product == null)
                {
                    throw new Exception($"something went wrong to retreive product(productId:({itemToAddDto.ProductId})");
                }
                //var newCartItemDto = newCartItem.ConvertToDto(product);
                //return CreatedAtAction(nameof(GetItem), new { id = newCartItemDto.Id }, newCartItemDto);
                return null;
         
            }
      
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
           
    }
}
