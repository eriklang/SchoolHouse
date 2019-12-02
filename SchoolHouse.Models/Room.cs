using System.ComponentModel.DataAnnotations;

namespace SchoolHouse.Models
{

    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        public string Building { get; set; }
        public string Floor { get; set; }
        public string RoomName { get; set; }
        public int RoomCapacity { get; set; }
    }
}