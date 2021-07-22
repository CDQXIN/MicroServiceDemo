using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Controllers
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string image { get; set; }
        public static List<Products> GetProducts()
        {
            return new List<Products>() {
        new Products { Id = 1, ProductName="Ace",Price = 1888, image = "http://127.0.0.1:1596/Ultraman/ace1.jpg"},
        new Products { Id = 2, ProductName="Taro",Price = 1788, image = "http://127.0.0.1:1596/Ultraman/ace2.jpg"},
        new Products { Id = 3, ProductName="Leo",Price = 1688, image = "http://127.0.0.1:1596/Ultraman/ace3.jpg"},
        new Products { Id = 4, ProductName="Astra",Price = 1588, image = "http://127.0.0.1:1596/Ultraman/ace4.jpg"},
        new Products { Id = 5, ProductName="80",Price = 1800, image = "http://127.0.0.1:1596/Ultraman/ace5.jpg"},
        new Products { Id = 6, ProductName="Yullian",Price = 1300, image = "http://127.0.0.1:1596/Ultraman/ace6.jpg"},
        };
        }
    }
}
