using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VendorId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime OrderTime { get; set; }
        public Product Product { get; set; }

    }
}
