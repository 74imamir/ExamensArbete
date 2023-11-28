using System.ComponentModel.DataAnnotations;

namespace ExamensArbete.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Language Name")]
        [Display(Name = "Language Name")]
        public string Name { get; set; }
        public virtual List<Team> Teams { get; set; }
        public virtual List<Category> Categories{ get; set; }
        public virtual List<ContactUs> ContactUs { get; set; }


    }
}
