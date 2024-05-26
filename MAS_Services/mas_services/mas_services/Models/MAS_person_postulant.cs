using System.ComponentModel.DataAnnotations;

namespace mas_services.Models
{
    public class MAS_person_postulant
    {
        [Key]
        public int id { get; set; }
        public string? firstName { get; set; }
        public string? secondName { get; set; }
        public string? lastName { get; set; }
        public string? surName { get; set; }
        public int idTypeIdentification { get; set; }
        public MAS_type_identification? mAS_Type_Identification { get; set; }
        public string? numberIdentification { get; set; }
        public bool state { get; set; }
        public List<MAS_user_postulant>? MAS_userPostulantList { get; set; }
    }
}
