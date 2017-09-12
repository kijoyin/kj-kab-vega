using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vega.Controllers
{
    [Route("api/[controller]s")]
    public class FeatureController:Controller
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new List<string>(){"Reverse Camera","Windscreen","4WD"};
        }
        
    }
}