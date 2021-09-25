using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime ExpectedDelivery { get; set; }
        public Product Product { get; set; }
    }
}
