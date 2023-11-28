using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamensArbete.Models
{
    public class Research
    {
        [Key]
        [Display(Name = "Research Id")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortText { get; set; }
        public string LongText { get; set; } //read more
        public int Visit { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }
        public int AuthorId { get; set; } //foreign key
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; } //navigation property .baraye in ke befahmim in tahghigh marbot be chand ta research boode 
        // ya chand ta research dar da an soorat gerefte.
        public int LanguageId { get; set; }
        [ForeignKey("LanguageId")]
        public string Image { get; set; } // baraye akshaye dakhele research
        public int CategoryId { get; set; } // mikhahim bedanim in research be kodom category marboot ast.
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } //navigation property


    }
}
