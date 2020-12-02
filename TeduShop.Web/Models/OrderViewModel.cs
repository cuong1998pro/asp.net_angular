using System;
using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerMessage { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreadBy { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { get; set; }
    }
}