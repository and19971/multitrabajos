using System.ComponentModel.DataAnnotations;

namespace mas_services.Models
{
    public class MAS_position
    {
        [Key]
        public int POS_ID { get; set; }
        public string? POS_DESCRIPTION { get; set; }
        public bool POS_STATE { get; set; }
    }
}
