using EventTicketing.Data.Dto;
using EventTicketing.Models;

namespace EventTicketing.Data
{
    public static class EventStore
    {
        public static List<EventDto> eventList = new List<EventDto> {
                new EventDto { Id = 1, Name = "Voyage to Gishen", EventDate = new DateTime(2021, 5, 31) },
                new EventDto { Id = 2, Name = "Voyage to Lalibela", EventDate = new DateTime(2021, 5, 31) },
                new EventDto { Id = 3, Name = "Voyage to Kibran", EventDate = new DateTime(2021, 5, 31) },
                new EventDto { Id = 4, Name = "Voyage to Tsion", EventDate = new DateTime(2021, 5, 31) }
        };
    }
}
