using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamensArbete.Models
{
    public class ContactUs
    {
        [Key]
        [Display(Name = "Contact US Id")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Contact Name")]
        [Display(Name = "Company Name")]
        [StringLength(150)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(800)]
        public string Address { get; set; }
        public string Discription { get; set; }
        [MaxLength(250)]
        public string Facebook { get; set; }
        [MaxLength(250)]
        public string Twitter { get; set; }
        [MaxLength(250)]
        public string Youtube { get; set; }
        [MaxLength(250)]
        public string Instagram { get; set; }

        public int LanguageId { get; set; }
        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; } 

    }
}
