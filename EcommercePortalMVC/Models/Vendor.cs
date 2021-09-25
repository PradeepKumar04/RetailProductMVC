using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public double Rating { get; set; }
        public double DeliveryCharges { get; set; }


        public List<Vendor> GetVendors()
        {
            List<Vendor> vendors = new List<Vendor>()
            {
                new Vendor(){Id=1,VendorName="Purna",Rating=4.2,DeliveryCharges=100},
                new Vendor(){Id=2,VendorName="Karthik",Rating=4.2,DeliveryCharges=100}
            };
            return vendors;
        }

    }
}
