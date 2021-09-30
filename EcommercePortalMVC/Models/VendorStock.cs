using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class VendorStock
    {
        public int VendorId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpectedStockReplinshmentDate { get; set; }


        
        public Vendor GetVendorByProductId(int productId)
        {
            Vendor vendor = null;
            string url = String.Format("https://localhost:44380/GetVendor/" + productId);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var responseTask = client.GetAsync("");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var result1 = result.Content.ReadAsStringAsync().Result;
                    vendor= JsonConvert.DeserializeObject<Vendor>(result1);
                }
            }
            return vendor;
        }
    }

    
}
