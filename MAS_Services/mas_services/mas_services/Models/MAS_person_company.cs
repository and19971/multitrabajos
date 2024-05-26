using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace mas_services.Models
{
    public class MAS_person_company
    {
        [Key]
        public int PER_ID { get; set; }
        public string? PER_FIRST_NAME { get; set; }
        public string? PER_SECOND_NAME { get; set; }
        public string? PER_LAST_NAME { get; set; }
        public string? PER_SUR_NAME { get; set; }
        [ForeignKey("MAS_Type_Identification")]
        public int PER_FK_TYPE_IDENTIFICATION { get; set; }
        public MAS_type_identification? MAS_Type_Identification { get; set; }
        public string? PER_NUMBER_IDENTIFICATION { get; set; }
        [ForeignKey("MAS_position")]
        public int PER_FK_POSITION { get; set; }
        public MAS_position? MAS_position { get; set; }
        public bool PER_STATE { get ; set; }
    
    }
}
