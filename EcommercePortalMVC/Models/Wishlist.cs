using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAddedToWishList { get; set; }
        public Product Product { get; set; }


        public List<Wishlist> GetWishlists(int id)
        {
            List<Wishlist> wishlists = null;
            string url = String.Format("https://localhost:44380/GetWishList/"+id);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var responseTask = client.GetAsync("");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var result1 = result.Content.ReadAsStringAsync().Result;
                    wishlists = JsonConvert.DeserializeObject<List<Wishlist>>(result1);
                }
            }
            return wishlists.OrderBy(s=>s.DateAddedToWishList).ToList();
        }

        public async Task<bool> RemoveProductFromWishlist(int uid,int pid)
        {
            using (var client = new HttpClient())
            {
                
                var url = "https://localhost:44380/RemoveProductFromWishlist/" + uid + "/" + pid;
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

        public async Task<bool> AddToWishlistAsync(Wishlist wishlist)
        {
            using (var client = new HttpClient())
            {
                StringContent data = null;
                var url = "https://localhost:44380/PostWishlist/" + wishlist.Id + "/" + wishlist.ProductId;
                var client1 = new HttpClient();

                //Pass in the full URL and the json string content
                var response = await client.PostAsync(url, data);
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
    }
}
