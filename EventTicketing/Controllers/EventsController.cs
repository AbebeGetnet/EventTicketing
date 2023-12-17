using EventTicketing.Data;
using EventTicketing.Data.Dto;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<EventDto>> GetAllEvents() 
        {
            return Ok(EventStore.eventList);
        }
        [HttpGet("id:int",Name ="GetEvent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<EventDto> GetEvent(int id) 
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var eventList = EventStore.eventList.FirstOrDefault(e => e.Id == id);
            if(eventList == null)
            {
                return NotFound();
            }
            return Ok(eventList);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<EventDto> CreateEvent([FromBody]EventDto eventDto)
        {
            if(eventDto == null)
            {
                return BadRequest(eventDto);
            }
            if(eventDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            eventDto.Id = EventStore.eventList.OrderByDescending(e => e.Id).FirstOrDefault().Id + 1;
            EventStore.eventList.Add(eventDto);
            return CreatedAtRoute("GetEvent",new {id = eventDto.Id},eventDto);
        }
    }

}
