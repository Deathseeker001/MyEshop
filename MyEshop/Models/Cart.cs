namespace MyEshop.Models
{
    public class Cart
    {
        public Cart()
        {
            CartItem = new List<CartItem>();
        }
        public int OrderId { get; set; }
        public List<CartItem> CartItem { get; set; }
        public void addItem(CartItem item)
        {
            if (CartItem.Exists(i => i.Id == item.Id))
            {
                CartItem.Find(i => i.Item.Id == item.Item.Id).Quantity += 1;
            }
            else
            {
                CartItem.Add(item);
            }

        }
        public void removeItem(int itemId)
        {
            var item = CartItem.SingleOrDefault(c => c.Item.Id == itemId);
            if (item?.Quantity <= 1)
            {
                CartItem.Remove(item);
            }
            else if (item! == null)
            {
                item.Quantity -= 1;
            }
        }
    }
}
