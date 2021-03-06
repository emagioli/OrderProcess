using System;
using System.Collections.Generic;
using System.Text;
using PEDIDO.Entities;
using PEDIDO.Entities.Enums;

namespace PEDIDO
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, List<OrderItem> items, Client client)
        {
            Moment = moment;
            Status = status;
            Items = items;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem i in Items)
            {
                total += i.SubTotal();
            }
            return total;
        }
    }
}
