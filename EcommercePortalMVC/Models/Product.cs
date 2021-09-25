using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image_Name { get; set; }
        public double Rating { get; set; }

        public List<Product> GetProducts()
        {
             List<Product> products = new List<Product>() {

                new Product(){Id=1,Name="Asus TUF Gaming",Image_Name="https://dlcdnrog.asus.com/rog/media/1622468922392.jpg",Description="Super Fast Gaming Laptop",Price=59000,Rating=4.4},
                new Product(){Id=2,Name="Iphone 13",Image_Name="https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-pro-family-hero?wid=940&hei=1112&fmt=png-alpha&.v=1631220221000",Description="A selfie camera only for you",Price=79999,Rating=4.6},
                new Product(){Id=3,Name="IFB Washing Machine",Image_Name="https://5.imimg.com/data5/CK/KE/MY-41600229/ifb-washing-machine-500x500.jpg",Description="Spend Some More time with your family",Price=29000,Rating=3.4},
                new Product(){Id=4,Name="Amazon Kindle",Image_Name="https://akm-img-a-in.tosshub.com/indiatoday/images/story/201812/Kindle_Paperwhite_2018_main.jpeg?gshQjB9db5byoFTMtzZAEbIAHjaE6_zn&",Description="Learn new Things",Price=22000,Rating=3.4},
                new Product(){Id=5,Name="Samsung 48 inc TV",Image_Name="https://m.media-amazon.com/images/I/713lv58SqEL._SL1000_.jpg",Description="Have theather Experience at home",Price=40000,Rating=3.4},
                new Product(){Id=6,Name="Ant Earpods",Image_Name="https://media.croma.com/image/upload/f_auto,q_auto,d_Croma%20Assets:no-product-image.jpg,h_350,w_350/v1605330296/Croma%20Assets/Entertainment/Headphones%20and%20Earphones/Images/8944809639966.png",Description="Don't Get Bored..",Price=2000,Rating=3.4},
                new Product(){Id=7,Name="Sony I1063 Camera",Image_Name="https://22z0n11qmoz3ncbr3xafxk5z-wpengine.netdna-ssl.com/wp-content/uploads/2021/03/The-Complete-Setup-Guide-to-the-Sony-A1-Mirrorless-Camera-1024x683.jpg",Description="Capture a great Moments ",Price=22880,Rating=3.4},

            };
            return products;
        }
    }
}
