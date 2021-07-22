﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HeartController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok();
        }
    }
}
