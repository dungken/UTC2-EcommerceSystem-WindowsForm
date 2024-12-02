using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Primary Key
        public DateTime OrderDate { get; set; } // Order date
        public string Status { get; set; } // Order status (Pending, Completed, Cancelled)
        public decimal TotalAmount { get; set; } // Total order amount
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

      
    }
}