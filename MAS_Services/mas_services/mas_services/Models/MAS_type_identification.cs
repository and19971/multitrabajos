using System.ComponentModel.DataAnnotations;

namespace mas_services.Models
{
    public class MAS_type_identification
    {
        [Key]
        public int TYP_ID { get; set; }
        public string? TYP_DESCRIPTION { get; set; }
        public bool TYP_state { get; set; }
      
    }
}
