using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET: api/Events
        [HttpGet]
        public JsonResult Get(bool? randomOrder = false)
        {
            string allEventData = System.IO.File.ReadAllText(@"wwwroot\assets\data\events.json");

            List<Event> items = JsonConvert.DeserializeObject<List<Event>>(allEventData).OrderBy(e => e.Title).ToList();

            if (randomOrder.HasValue && randomOrder.Value)
            {
                items = items.OrderBy(i => Guid.NewGuid()).ToList();
            }

            return new JsonResult(items);
        }
    }
}
