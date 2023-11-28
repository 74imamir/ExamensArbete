using ExamensArbete.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;





namespace ExamensArbete.Models
{
    public class Author
    {
        [Key]
        [Display(Name = "Author Id")]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = " Name")]
        public string Name { get; set; }
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        
        public string lastName { get; set; }

        [MaxLength(60)]
        
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(300)]
        public string ImagePath { get; set; }

        //public IFormFile ImagePathFile { get; set; }

        [MaxLength(800)]
        public string Address { get; set; }

        public string Facebook { get; set; }

        [MaxLength(250)]
        public string Twitter { get; set; }

        public virtual List<Research> Researches { get; set; }
    }
}
