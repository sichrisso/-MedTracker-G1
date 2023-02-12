
namespace MedAdvisor.Models
{
  public class Document
    {
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
    }
}
