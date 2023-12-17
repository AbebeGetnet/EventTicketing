using System.ComponentModel.DataAnnotations;

namespace EventTicketing.Data.Dto
{
    public class EventDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
    }
}
