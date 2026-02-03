//using Microsoft.EntityFrameworkCore.Tools;
using System.ComponentModel.DataAnnotations;
namespace Repo {
    public class Book
    {
        [Required][MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int publishyear { get; set; }

    }
    }
    
