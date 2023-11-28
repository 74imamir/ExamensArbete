using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamensArbete.Models
{
    public class Team
    {
        [Key]
        [Display(Name = "Team Id")]
        public int Id { get; set; }
        [Display(Name = "Team Name")]
        public string Name { get; set; }
        public string LastName { get; set; }    
        public string ImagePath { get; set; }
        public string Position { get; set; }
        public string Biography { get; set; }
        public string Instagram { get; set; }
        public string Phone { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public string Twitter { get; set; }
        public int LanguageId { get; set; }
        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }



    }
}
