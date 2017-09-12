using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vega.ViewModels;

namespace vega.Controllers
{
    [Route("api/[controller]s")]
    public class MakeController:Controller
    {
        [HttpGet]
        public IEnumerable<Make> GetAll()
        {
            return new List<Make>(){GetMake("KIA"),GetMake("Tayota"),GetMake("Ford")};
        }

        public Make GetMake(string name)
        {
            return new Make()
            {
                Id = Guid.NewGuid(),
                Name = name
            };
        }
        
    }
}