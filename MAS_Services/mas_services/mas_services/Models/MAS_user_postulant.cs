using System.ComponentModel.DataAnnotations;

namespace mas_services.Models
{
    public class MAS_user_postulant
    {
        [Key]
        public int id { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public int attempts { get; set; }
        public DateTime lastPasswordChanged { get; set; }
        public string? profilePicture { get; set; }
        public int idPersonCompany { get; set; }
        public MAS_person_postulant? MAS_person_postulant { get; set; }
        public bool state { get; set; }
    }
}
