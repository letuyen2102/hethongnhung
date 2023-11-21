using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnMonHTN.Models
{
    public class Logs
    {
        [Key]
        public string LogId { get; set; }
        public string CardId { get; set; }
        [ForeignKey("CardId")]
        public User User { get; set; }
        public string Did { get; set; }
        [ForeignKey("Did")]
        public Device Device { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
