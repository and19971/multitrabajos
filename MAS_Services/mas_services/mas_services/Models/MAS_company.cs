using System.ComponentModel.DataAnnotations;

namespace mas_services.Models
{
    public class MAS_company
    {
        [Key]
        public int id { get; set; }
        public string? companyName { get; set; }
        public string? businessName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
        public int idTypeIndustry{ get; set; }
        public MAS_type_industry? MAS_type_industry { get; set; }
        public int quantityEmployees { get; set; }
        public int idPerson { get; set; }
        public MAS_person_company? MAS_person_company { get; set; }
        public bool state { get; set; }
    }
}
