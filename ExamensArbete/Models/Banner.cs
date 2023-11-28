using System.ComponentModel.DataAnnotations;

namespace ExamensArbete.Models
{
    public class Banner
    {
        [Key]
        [Display(Name = "Banner Id")]
        public int Id { get; set; }
        public string ImagePath { get; set; }
        [MaxLength(300)]
        public string Text { get; set; }
        [MaxLength(200)]
        public DateTime CreateDate { get; set; }


    }
}
