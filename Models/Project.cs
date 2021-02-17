using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5.Models
{
    public class Project
    {
        //create model attributes
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        public string? MiddleInt { get; set; } = "";
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [RegularExpression("^[0-9]+(-[0-9]+)+$")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }

    }

}
