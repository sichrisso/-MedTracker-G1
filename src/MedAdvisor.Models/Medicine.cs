
namespace MedAdvisor.Models
{
    public class Medicine
    {
        public int UserId { get; set; }
        public int MedicineId { get; set; }
        public string MedicineName { get; set; } = string.Empty;
    }
}