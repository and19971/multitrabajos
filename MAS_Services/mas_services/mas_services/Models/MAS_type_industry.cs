using System.ComponentModel.DataAnnotations;

namespace mas_services.Models
{
    public class MAS_type_industry
    {
        [Key]
        public int id { get; set; }
        public string? description { get; set; }
        public bool state { get; set; }
        public List<MAS_company>? MAS_companyList { get; set; }
    }
}
