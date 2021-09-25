using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class VendorStock
    {
        public int VendorId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpectedStockReplinshmentDate { get; set; }


        public List<VendorStock> GetStocks()
        {
            List<VendorStock> vendorStocks = new List<VendorStock>()
            {
                new VendorStock(){VendorId=1,ProductId=1,Quantity=5,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=2,ProductId=1,Quantity=6,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=1,ProductId=2,Quantity=5,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=1,ProductId=3,Quantity=5,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=1,ProductId=4,Quantity=5,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=1,ProductId=5,Quantity=0,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=1,ProductId=6,Quantity=5,ExpectedStockReplinshmentDate=DateTime.Now},
                new VendorStock(){VendorId=1,ProductId=7,Quantity=5,ExpectedStockReplinshmentDate=DateTime.Now},
            };
            return vendorStocks;
        }
    }

    
}
