namespace PEDIDO
{
    internal class OrderItem<T>
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}