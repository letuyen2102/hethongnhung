using System.ComponentModel.DataAnnotations;

namespace DoAnMonHTN.Models
{
    public class Device
    {
        [Key]
        public string Did { get; set; }
        public string Name { get; set; }
    }
}
