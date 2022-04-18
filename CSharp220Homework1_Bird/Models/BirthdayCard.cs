using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BirthdayCard
    {
        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
