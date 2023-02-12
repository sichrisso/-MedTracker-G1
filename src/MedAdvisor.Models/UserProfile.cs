using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MedAdvisor.Models
{

    public class UserProfile
    {

        public int UserId { get; set; }
        public string? Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Name must be at least 4 characters long.")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Last name must be at least 4 characters long.")]
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enum Gendertypes
        {
            Female,
            Male
        }
        public Gendertypes Gender { get; set; }
        public string Ssn { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public bool OrganDonor { get; set; }
        public string Postnr { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Land { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string TypeOfInsurance { get; set; } = string.Empty;
        public string InsuranceCompany { get; set; } = string.Empty;
        public string AlarmTel { get; set; } = string.Empty;
        public string EmergencyContacts { get; set; } = string.Empty;
        public string Other { get; set; } = string.Empty;

        public ICollection<Allergy> Allergies { get; set; } = null!;

        public ICollection<Diagnose> Diagnoses { get; set; } = null!;

        public ICollection<Medicine> Medicines { get; set; } = null!;

        public ICollection<Vaccine> Vaccines { get; set; } = null!;

        public ICollection<Document> Documents { get; set; } = null!;
    }
}
