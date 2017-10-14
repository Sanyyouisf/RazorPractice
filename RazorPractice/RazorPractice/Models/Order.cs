using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorPractice.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string City { get; set; }
    }
}