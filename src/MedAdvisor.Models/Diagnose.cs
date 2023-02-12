
namespace MedAdvisor.Models
{ 
    public class Diagnose
    {
        public int UserId { get; set; }
        public int DiagnoseId { get; set; }
        public string DiagnoseName { get; set; } = string.Empty;
    }
}