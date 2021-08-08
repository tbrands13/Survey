using System;
using System.ComponentModel.DataAnnotations;

namespace Survey.Models
{
    public class Form
    {
        // Name
        [Required]
        public string Name {get;set;}
        // Location
        [Required]
        public string Location {get;set;}
        // Language
        [Required]
        public string Language {get;set;}
        // Comment
        [MaxLength(20, ErrorMessage ="Comment must be 20 characters or less")]
        public string Comment {get;set;}
    }

}