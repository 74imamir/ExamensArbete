using System.ComponentModel.DataAnnotations;

namespace ExamensArbete.Models
{
    public class Gallery
    {
        [Key]
        [Display(Name = "Gallery Id")]
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Discription { get; set; }
        public DateTime CreateDate { get; set; }



    }
}
