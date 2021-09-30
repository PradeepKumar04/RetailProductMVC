using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ZipCode { get; set; }
        public Product Product { get; set; }

        public List<Cart> GetCartsById(int id)
        {
            List<Cart> carts = null;
           
            
            string url = String.Format("https://localhost:44380/GetCartById/"+id);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var responseTask = client.GetAsync("");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var result1 = result.Content.ReadAsStringAsync().Result;
                    carts = JsonConvert.DeserializeObject<List<Cart>>(result1);
                }
            }
            return carts.OrderBy(s=>s.DeliveryDate).ToList();
        }


        public async Task<bool> RemoveProductFromCart(int uid, int pid)
        {
            using (var client = new HttpClient())
            {

                var url = "https://localhost:44380/RemoveProductFromCart/" + uid + "/" + pid;
                var client1 = new HttpClient();

                //Pass in the full URL and the json string content
                var response = await client.DeleteAsync(url);
                var resmess = response.RequestMessage;
                var result = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<Cart> AddProductToCartAsync()
        {
            Cart c = null;
            using (var client = new HttpClient())
            {

                string json = JsonConvert.SerializeObject(this);

                //Needed to setup the body of the request
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


                //The url to post to.
                var url = "https://localhost:44380/GetCart";
                var client1 = new HttpClient();

                //Pass in the full URL and the json string content
                var response = await client.PostAsync(url, data);
                var resmess = response.RequestMessage;
                var result = response.Content.ReadAsStringAsync().Result;
                if(result.Equals("Item Already in Cart"))
                {
                    return null;
                }
                if(result.Equals("Out of Stock"))
                {
                    return new Cart();
                }
                else
                {
                    c = JsonConvert.DeserializeObject<Cart>(result);
                }
                if (response.IsSuccessStatusCode)
                {
                    return c ;
                }
                else
                {
                    return null;
                }
                //It would be better to make sure this request actually made it through


            }
        }
    }
}
