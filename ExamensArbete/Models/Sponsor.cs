using System.ComponentModel.DataAnnotations;

namespace ExamensArbete.Models
{
    public class Sponsor
    {
        [Key]
        [Display(Name = "Sponsor Id")]
        public int Id { get; set; }
        [Display(Name = "Sponsor Name")]
        [Required(ErrorMessage = "Enter Sponsor Name")]
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
    }
}
