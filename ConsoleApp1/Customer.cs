
//using Microsoft.EntityFrameworkCore.Tools;
using System.ComponentModel.DataAnnotations;
namespace Repo {
    public class Customer
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int NationalCode { get; set; }
        [Required]  
        public DateTime Birthday { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
    
