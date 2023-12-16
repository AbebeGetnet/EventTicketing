using System.Threading;

namespace EventTicketing.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        //public TimeOnly StartAt { get; set; }
        //public TimeOnly EndAt { get; set; }
    }
}
