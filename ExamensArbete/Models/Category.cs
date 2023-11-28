using Microsoft.Win32.SafeHandles;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamensArbete.Models
{
    public class Category
   
    {
        [Key]
        [Display(Name = "Category Id")]

        public int Id { get; set; }
        
        [MaxLength(300)]
        public string Name { get; set; }
        public virtual List<Research> Researches { get; set; }
        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
    }
}
