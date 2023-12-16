using EventTicketing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EventTicketing.Controllers
{
    [Route("api/events")]
    [ApiController]

    public class EventsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetAllEvents() 

        {
            return new List<Event> {
                new Event { Id = 1, Name = "Voyage to Gishen", EventDate = new DateTime(2021, 5, 31) },
                new Event { Id = 2, Name = "Voyage to Lalibela", EventDate = new DateTime(2021, 5, 31) },
                new Event { Id = 3, Name = "Voyage to Kibran", EventDate = new DateTime(2021, 5, 31)  },
                new Event { Id = 4, Name = "Voyage to Tsion", EventDate = new DateTime(2021, 5, 31) }
        };
        }
    }

}
