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
    }
}
