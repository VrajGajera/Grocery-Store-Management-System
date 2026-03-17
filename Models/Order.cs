using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grosary_net.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }

        public string ShippingAddress { get; set; }

        public string PaymentMethod { get; set; }

        // ORDER ITEMS
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}