
//using Microsoft.EntityFrameworkCore.Tools;
using System.ComponentModel.DataAnnotations;
namespace Repo {
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public int NationalCode { get; set; }
        [Required]  
        public DateTime Birthday { get; set; }
        [Required]
        public string Address { get; set; }
    }


    public class Product
        {
        [Required]
        public int Id { get; set; }

        public string ProductName { get; set; }
            public double Price { get; set; }
            public string Seller{ get; set; }
        
        }
}
    
