namespace Shop.api.Entities
{
    public class CartItems
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set;}
        public int Qty { get; set; }

    }
}
