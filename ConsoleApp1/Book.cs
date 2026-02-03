//using Microsoft.EntityFrameworkCore.Tools;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Repo {
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [Required][MaxLength(100)]
        public string BookName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int publishyear { get; set; }

    }
    }
    
