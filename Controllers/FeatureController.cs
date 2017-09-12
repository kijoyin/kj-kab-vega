using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vega.ViewModels;

namespace vega.Controllers
{
    [Route("api/[controller]s")]
    public class FeatureController:Controller
    {
        [HttpGet]
        public IEnumerable<Feature> GetAll()
        {
            return new List<Feature>(){GetFeature("Reverse Camera"),GetFeature("Windscreen"),GetFeature("4WD")};
        }

        public Feature GetFeature(string name)
        {
            return new Feature()
            {
                Id = Guid.NewGuid(),
                Name = name
            };
        }
        
    }
}