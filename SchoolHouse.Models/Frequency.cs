using System.ComponentModel.DataAnnotations;

namespace SchoolHouse.Models
{
     public class Frequency
    {
        [Key]
        public int FrequencyID { get; set; }

        public string DayOfTheWeek { get; set; }
        public string StartTime { get; set; }
        public int LengthInMinutes { get; set; }
    }
}