
namespace MedAdvisor.DataAccess.Mysql
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string JoinedDate { get; set; } = string.Empty;
        public enum Gender
        {
            Female, Male
        }
        public string BirthDate { get; set; } = string.Empty;
        public bool OrganDonor { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public int Telephone { get; set; }
        public string PostalAddress { get; set; } = string.Empty;
        public string TravelInsurance { get; set; } = string.Empty;
        public int PostalNumber { get; set; }
        public string AlarmTelephone { get; set; } = string.Empty;
        public int EmergencyContacts { get; set; }
        public string Other { get; set; } = string.Empty;



    }
}