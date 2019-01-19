using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}