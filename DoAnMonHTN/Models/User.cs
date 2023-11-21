using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnMonHTN.Models
{
    public class User
    {
        [Key]
        public string CardId { get; set; }
        public string Name { get; set; }
        public bool  IsAdmin { get; set; } = false;
    }
}
