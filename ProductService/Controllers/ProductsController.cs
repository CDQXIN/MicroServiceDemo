using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("product/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
            [HttpGet]
            public IEnumerable<Products> Get()
            {
                return Products.GetProducts();
            }
        
    }
}
