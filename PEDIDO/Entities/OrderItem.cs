using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace PEDIDO.Entities.Enums
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, price)
        {
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Product.Name}, ");
            sb.Append($"${Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            sb.Append($"Quantity: {Quantity}, ");
            sb.Append($"Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();

        }
    }
}
